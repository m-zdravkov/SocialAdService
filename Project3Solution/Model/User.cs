using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class User
    {
        public string Id { get; set; }
        [MaxLength(256)]
        [Index(IsUnique = true)]
        public string Email { get; set; }
        public string Name { get; set; }
        [SettingsBindable(false)]
        public byte[] PasswordHash { get; set; }
        [SettingsBindable(false)]
        public byte[] Salt { get; set; }
        public string PictureURL { get; set; }
        public int Reservations { get; set; }
        public int Boosts { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}
