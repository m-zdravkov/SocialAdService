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

        public static void Seed()
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
    }
}
