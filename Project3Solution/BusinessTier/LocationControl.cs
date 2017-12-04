using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

namespace BusinessTier
{
    public class LocationControl
    {
        private static LocationControl _instance;


        public static LocationControl GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LocationControl();
            }
            return _instance;
        }

        private LocationControl()
        {
            SeedLocations();
        }

        /// <summary>
        /// Makes sure we have placeholder locations in the database, if we find out that it's empty.
        /// </summary>
        private void SeedLocations()
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();
            int count = db.Locations.Count<Location>();
            if (count == 0)
            {
                MigrationSeed.SeedLocations();

                foreach (var location in MigrationSeed.Locations)
                {
                    RegisterLocation(location.Name, location.Type, location.Parent?.Name);
                }
            }
        }

        /// <summary>
        /// This is an administrative method, not available to users.
        /// </summary>
        public void RegisterLocation(string name, LocationType type, string parentName = null)
        {
            var db = DbContextControl.GetLastOrNew();

            Location parent = null;

            if (parentName != null)
                parent = AttachLocation(db, parentName);

            Location location = new Location
            {
                Name = name,
                Type = type,
                Parent = parent,
            };

            db.Locations.Add(location);
            db.SaveChanges();
        }

        /// <summary>
        /// Find a location from its name, since it's the only possible key.
        /// This queries the DB.
        /// </summary>
        /// <param name="name"></param>
        public Location GetLocation(string name)
        {
            var db = DbContextControl.GetLastOrNew();
            return db.Locations.Include("Parent").FirstOrDefault(l => l.Name.ToLower() == name.ToLower());
        }

        public Location GetLocation(ServiceDbContext context, string name)
        {
            return context.Locations.Include("Parent").FirstOrDefault(l => l.Name.ToLower() == name.ToLower());
        }

        /// <summary>
        /// Attaches a location to the DB context.
        /// Use this when combining with another method that accesses the DB.
        /// </summary>
        public Location AttachLocation(ServiceDbContext context, Location location)
        {
            return context.Locations.Attach(location);
        }

        /// <summary>
        /// Attaches a location to the DB context.
        /// Use this when combining with another method that accesses the DB.
        /// </summary>
        public Location AttachLocation(ServiceDbContext context, string name)
        {
            return context.Locations.Attach(new Location { Name = name });
        }

        /// <summary>
        /// Find a location from its name and delete it.
        /// </summary>
        public void DeleteLocation(string name)
        {
            var db = DbContextControl.GetNew();
            var toDelete = new Location { Name = name };
            db.Entry(toDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }

        /// <summary>
        /// Find a location from its name and schedule it for deleting on the DB context.
        /// </summary>
        public void AttachDeleteLocation(ServiceDbContext context, string name)
        {
            var toDelete = new Location { Name = name };
            context.Entry(toDelete).State = EntityState.Deleted;
        }

        /// <summary>
        /// Checks if a location is within another location.
        /// An example: Aalborg is within Nordjylland, is within Denmark
        /// LocationIsWithin("Aalborg","Denmark") ---> true
        /// </summary>
        /// <param name="name">Location in question</param>
        /// <param name="parent">The larger location</param>
        /// <returns></returns>
        public bool IsWithin(string name, string parent)
        {
            //Get a reference to a Database Context from Entity Framework
            var db = DbContextControl.GetLastOrNew();

            //Make sure that the name and parent arguments are existing locations
            Location current = GetLocation(db, name);
            Location parentLocation = GetLocation(db, parent);

            if (current == null)
                throw new LocationNotFoundException("Checking if non-existing location is within another.");
            if (parentLocation == null)
                throw new LocationNotFoundException("Checking if a location is within a non-existing one.");

            //Now we try to traverse the Location tree, to find if two locations are connected
            bool found = false; //Boolean flag to help us later
            
            //While the current location is not null and we haven't found a match
            while (current != null && !found)
            {
                //Check if the current location or its parent is the one parent we are looking for
                if (current.Name == parent || current.Parent?.Name == parent)
                    found = true;//This makes the end result true, and also terminates the condition of the loop

                //If there are no more parents, we are at the top of the tree and we are done searching
                if (current.Parent == null)
                {
                    //This terminates the condition of the loop
                    current = null;
                }
                else
                {
                    //Otherwise, switch to the parent of the current location and repeat the loop
                    current = GetLocation(db, current.Parent.Name);
                }
            }
            //If nothing is found, this remains false
            return found;
        }

        /// <summary>
        /// Get a list of all locations that contain this location.
        /// Starts with the current location.
        /// Ordered from smallest to largest containing location.
        /// </summary>
        /// <param name="location">The location whose parents you are looking for.</param>
        /// <returns></returns>
        public IList<Location> GetParents(Location location, bool locationIsAlreadyValidated = false)
        {
            var db = DbContextControl.GetLastOrNew();
            Location current = location;

            if (!locationIsAlreadyValidated)
            {
                //Check if the location exists in the database
                current = GetLocation(db, location?.Name);

                if (current == null)
                    throw new LocationNotFoundException();
            }

            IList <Location> locations = new List<Location>();

            //While we aren't at a null location
            while (current!=null)
            {
                //Add the current location to our list
                locations.Add(current);
                //Get the parent of the current (null if at the top of the tree)
                if (current.Parent == null)
                    current = null; //If no more parents, terminate the loop
                else current = GetLocation(current.Parent.Name);
            }

            return locations;
        }

        /// <summary>
        /// Returns all children of a location. Keeps the location in the list.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="locationIsAlreadyValidated"></param>
        /// <returns></returns>
        public IList<Location> GetChildren(Location location, bool locationIsAlreadyValidated = false)
        {
            var db = DbContextControl.GetLastOrNew();
            Location current = location;

            if (!locationIsAlreadyValidated)
            {
                //Check if the location exists in the database
                current = GetLocation(db, location?.Name);

                if (current == null)
                    throw new LocationNotFoundException();
            }

            //Find all locations whose parent is our location
            IQueryable<Location> query
                = db.Locations.Include("Parent").Where(l => l.Parent != null && l.Parent.Name == location.Name);

            int results = query.Count();
            IList<Location> validLocations = query.ToList();
            IList<string> children = validLocations.ToNameList(); //Children to check, per iteration
            //We need to loop this for the children of children, until we get no more new results
            bool iterate = true;
            while (iterate) //Do while there are still objects available
            {
                //Perform query to find all Locations whose parent is one of the previous children
                query = db.Locations.Include("Parent").Where(l => l.Parent != null && children.Contains(l.Parent.Name));
                //Count
                results = query.Count();
                if (results > 0)//Prepare next iteration
                {
                    var newList = query.ToList(); //Turn the query into list of objects
                    validLocations = validLocations.Concat(newList).ToList(); //Add the newfound locations to the total list
                    children = newList.ToNameList(); //Specify the children to check for in the next iteration
                }
                else iterate = false;
            }
            validLocations.Add(location);//Keep the current location in the list to simplify later use
            return validLocations;
        }
    }
}
