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
            var db = new ServiceDbContext();

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
            var db = new ServiceDbContext();
            return db.Locations.Include("Parent").FirstOrDefault(l => l.Name == name);
        }

        public Location GetLocation(ServiceDbContext context, string name)
        {
            return context.Locations.Include("Parent").FirstOrDefault(l => l.Name == name);
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
            var db = new ServiceDbContext();
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
            var db = new ServiceDbContext();
            
            //Make sure that the name and parent arguments are existing locations
            Location current = GetLocation(db, name);
            Location parentLocation = GetLocation(db, parent);

            if (current == null)
                throw new ArgumentException("Location not found (first parameter).");
            if (parentLocation == null)
                throw new ArgumentException("Location not found (second parameter).");

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
    }
}
