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
        public static ICollection<Ad> Ads { get; set; } = new LinkedList<Ad>();

        public static void SeedAll()
        {
            SeedUsers();
            SeedLocations();
            SeedAds();
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
                Name = "Odense",
                Type = LocationType.City,
                Parent = Locations.FirstOrDefault(l => l.Name == "Syddanmark")
            });

            Locations.Add(new Location
            {
                Name = "Aarhus",
                Type = LocationType.City,
                Parent = Locations.FirstOrDefault(l => l.Name == "Midtjylland")
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

        public static void SeedAds()
        {

            Ads.Add(new Ad { Author = new User { Name = "max.damage@test.com" }, Title = "Welcome to SAS", Content = "We'd like to welcome you to our service. You can begin browsing and posting your ads immediately. We wish you good luck!", Location = new Location { Name = "Aalborg" }, Type = AdType.Other});
            Ads.Add(new Ad { Author = new User { Name = "alfred.woden@test.com" }, Title = "Black sedan", Content = "I am selling my old black car. It's a sedan from 1994. Address: ####", Location = new Location { Name = "USA" }, Type = AdType.Selling});
            Ads.Add(new Ad { Author = new User { Name = "dan.wallace@test.com" }, Title = "Selling my old airsoft gun", Content = "I wish to sell my old airsoft gun. It's an M16, comes with gas cannister. Price negotiable.", Location = new Location { Name = "Aarhus" }, Type = AdType.Selling});
            Ads.Add(new Ad { Author = new User { Name = "max.damage@test.com" }, Title = "Selling red sports car", Content = "Red sports car for sale in Copenhagen. Come pick it up for 50 000 dkk.", Location = new Location { Name = "Copenhagen" }, Type = AdType.Selling});
            Ads.Add(new Ad { Author = new User { Name = "max.damage@test.com" }, Title = "Competition", Content = "We are organizing a jogging competition in Odense. Run 15 km for charity.", Location = new Location { Name = "Odense" }, Type = AdType.Event});
            Ads.Add(new Ad { Author = new User { Name = "max.payne@test.com" }, Title = "Painkillers", Content = "Does anyone have any good painkillers? I've run out. I got 5$, near Roscoe Str.", Location = new Location { Name = "USA" }, Type = AdType.Buying});
            Ads.Add(new Ad { Author = new User { Name = "max.damage@test.com" }, Title = "Selling blue sports car", Content = "Blue sports car for sale in Aarhus. 50 000 dkk and it's yours.", Location = new Location { Name = "Aarhus" }, Type = AdType.Selling});
            Ads.Add(new Ad { Author = new User { Name = "lauren.sharp@test.com" }, Title = "Need plumber ASAP", Content = "Can anyone recommend me a good plumber? My plumbing broke down in the bathroom, don't know who to call.", Location = new Location { Name = "Aalborg" }, Type = AdType.ServiceRequest});
            Ads.Add(new Ad { Author = new User { Name = "rebecca.james@test.com" }, Title = "Business Pictures", Content = "Hi. I'm a professional photographer with a studio in Aalborg and I take and edit pictures for your CV, LinkedIn, etc. 6 for 150 dkk.", Location = new Location { Name = "Aalborg" }, Type = AdType.ServiceOffer});
            Ads.Add(new Ad { Author = new User { Name = "max.damage@test.com" }, Title = "Selling black sports car", Content = "Black sports car for sale in Aalborg. Pick up for 45 000 dkk.", Location = new Location { Name = "Aalborg" }, Type = AdType.Selling});
            Ads.Add(new Ad { Author = new User { Name = "ian.avery@test.com" }, Title = "Record player", Content = "Selling my old 80s record player. Good condition. 200 dkk.", Location = new Location { Name = "Aalborg" }, Type = AdType.Selling});
            Ads.Add(new Ad { Author = new User { Name = "george.orwell@test.com" }, Title = "Books", Content = "Selling some of my books.", Location = new Location { Name = "Aarhus" }, Type = AdType.Selling});
        }
    }
}
