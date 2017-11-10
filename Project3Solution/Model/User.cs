using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] Salt { get; set; }
        public string PictureURL { get; set; }
        public int Reservations { get; set; }
        public int Boosts { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}
