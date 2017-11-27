using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Takes care of filling the database with test data after each migration.
    /// Some actions need to happen in the businees tier, so this class acts as a buffer.
    /// </summary>
    public static class MigrationSeed
    {
        public static ICollection<User> Users { get; set; } = new LinkedList<User>();
        public static ICollection<Location> Locations { get; set; } = new LinkedList<Location>();

        public static void SeedAll()
        {
            SeedUsers();
            SeedLocations();
        }

        public static void SeedUsers()
        {
            Users.Add(new User { Name = "Wanda Butler", Email = "wanda.butler@test.com" });
            Users.Add(new User { Name = "Olivia Metcalfe", Email = "olivia.metcalfe@test.com" });
            Users.Add(new User { Name = "Rebecca James", Email = "rebecca.james@test.com" });
            Users.Add(new User { Name = "Dan Wallace", Email = "dan.wallace@test.com" });
            Users.Add(new User { Name = "Molly Tucker", Email = "molly.tucker@test.com" });
            Users.Add(new User { Name = "Christopher Metcalfe", Email = "christopher.metcalfe@test.com" });
            Users.Add(new User { Name = "Lauren Sharp", Email = "lauren.sharp@test.com" });
            Users.Add(new User { Name = "Oliver Peterson", Email = "oliver.peterson@test.com" });
            Users.Add(new User { Name = "Hannah Bower", Email = "hannah.bower@test.com" });
            Users.Add(new User { Name = "Vanessa Wilkins", Email = "vanessa.wilkins@test.com" });
            Users.Add(new User { Name = "Max Payne", Email = "max.payne@test.com" });
            Users.Add(new User { Name = "Ian Avery", Email = "ian.avery@test.com" });
            Users.Add(new User { Name = "Sonia Andersen", Email = "sonia.andersen@test.com" });
            Users.Add(new User { Name = "Ruth Fraser", Email = "ruth.fraser@test.com" });
            Users.Add(new User { Name = "Connor Fraser", Email = "connor.fraser@test.com" });
            Users.Add(new User { Name = "Angela Henderson", Email = "angela.henderson@test.com" });
            Users.Add(new User { Name = "George Bochev", Email = "george.bochev@test.com" });
            Users.Add(new User { Name = "Wallace Breen", Email = "wallace.breen@test.com" });
            Users.Add(new User { Name = "Jim Bravura", Email = "jim.bravura@test.com" });
            Users.Add(new User { Name = "Alfred Woden", Email = "alfred.woden@test.com" });
            Users.Add(new User { Name = "Gylve Nagell", Email = "fenriz@test.com" });
            Users.Add(new User { Name = "Ted Skjellum", Email = "ted.skjellum@test.com" });
            Users.Add(new User { Name = "Harald Foss", Email = "harald.foss@test.com" });
            Users.Add(new User { Name = "Isaac Kleiner", Email = "isaac.kleiner@test.com" });
            Users.Add(new User { Name = "Max Damage", Email = "max.damage@test.com" });
            Users.Add(new User { Name = "Ben Dover", Email = "ben.dover@test.com" });
            Users.Add(new User { Name = "Mein Schaft", Email = "mein.schaft@test.com" });
            Users.Add(new User { Name = "Mike Hawke", Email = "mike.hawke@test.com" });
            Users.Add(new User { Name = "Jeckyl Hyde", Email = "jeckyl.hyde@test.com" });
            Users.Add(new User { Name = "George Orwell", Email = "george.orwell@test.com" });
            Users.Add(new User { Name = "Howard Wells", Email = "howard.wells@test.com" });
            Users.Add(new User { Name = "Henry Ford", Email = "henry.ford@test.com" });
            Users.Add(new User { Name = "Mr. Krabs", Email = "mrkrabs@test.com" });
            //Users.Add(new User { Name = "", Email = "@test.com" });
        }

        public static void SeedLocations()
        {
            Locations.Add(new Location { Name = "Denmark", Type = LocationType.Country } );
            Locations.Add(new Location { Name = "Norway", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Sweden", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Finland", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Iceland", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Denmark - Faroe Islands", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Denmark - Greenland", Type = LocationType.Country });
            Locations.Add(new Location { Name = "USA", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Canada", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Australia", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Germany", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Austria", Type = LocationType.Country });
            Locations.Add(new Location { Name = "France", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Belgium", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Switzerland", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Spain", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Portugal", Type = LocationType.Country });
            Locations.Add(new Location { Name = "United Kingdom", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Russia", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Ukraine", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Belarus", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Moldova", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Romania", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Bulgaria", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Greece", Type = LocationType.Country });
            Locations.Add(new Location { Name = "FYROM", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Serbia", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Croatia", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Slovenia", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Slovakia", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Czech Republic", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Poland", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Lithuania", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Latvia", Type = LocationType.Country });
            Locations.Add(new Location { Name = "Estonia", Type = LocationType.Country });

            //Regions
            Locations.Add(new Location
            {
                Name = "Nordjylland",
                Type = LocationType.Region,
                Parent = Locations.FirstOrDefault(l => l.Name == "Denmark")
            });

            Locations.Add(new Location
            {
                Name = "Hovedstaden",
                Type = LocationType.Region,
                Parent = Locations.FirstOrDefault(l => l.Name == "Denmark")
            });

            Locations.Add(new Location
            {
                Name = "Sjælland",
                Type = LocationType.Region,
                Parent = Locations.FirstOrDefault(l => l.Name == "Denmark")
            });

            Locations.Add(new Location
            {
                Name = "Syddanmark",
                Type = LocationType.Region,
                Parent = Locations.FirstOrDefault(l => l.Name == "Denmark")
            });

            Locations.Add(new Location
            {
                Name = "Midtjylland",
                Type = LocationType.Region,
                Parent = Locations.FirstOrDefault(l => l.Name == "Denmark")
            });

            //Cities
            Locations.Add(new Location
            {
                Name = "Aalborg",
                Type = LocationType.City,
                Parent = Locations.FirstOrDefault(l => l.Name == "Nordjylland")
            });

            Locations.Add(new Location
            {
                Name = "Hirtshals",
                Type = LocationType.City,
                Parent = Locations.FirstOrDefault(l => l.Name == "Nordjylland")
            });

            Locations.Add(new Location
            {
                Name = "Frederikshavn",
                Type = LocationType.City,
                Parent = Locations.FirstOrDefault(l => l.Name == "Nordjylland")
            });

            Locations.Add(new Location
            {
                Name = "Skagen",
                Type = LocationType.City,
                Parent = Locations.FirstOrDefault(l => l.Name == "Nordjylland")
            });

            //Areas
            Locations.Add(new Location
            {
                Name = "Centrum",
                Type = LocationType.Area,
                Parent = Locations.FirstOrDefault(l => l.Name == "Aalborg")
            });

            Locations.Add(new Location
            {
                Name = "Aalborg Øst",
                Type = LocationType.Area,
                Parent = Locations.FirstOrDefault(l => l.Name == "Aalborg")
            });

            Locations.Add(new Location
            {
                Name = "Skalborg",
                Type = LocationType.Area,
                Parent = Locations.FirstOrDefault(l => l.Name == "Aalborg")
            });
            
        }
    }
}
