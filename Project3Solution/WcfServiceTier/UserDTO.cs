using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTier
{
    [DataContract]
    public class UserDTO
    {
        [DataMember] public string Id { get; set; }
        [DataMember] public string Name { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public string PictureURL { get; set; }
        [DataMember] public int Boosts { get; set; }
        [DataMember] public int Reservations { get; set; }
        [DataMember] public DateTime DateRegistered { get; set; }

        public static UserDTO FromUser(User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                PictureURL = user.PictureURL,
                Boosts = user.Boosts,
                Reservations = user.Reservations,
                DateRegistered = user.DateRegistered,
            };
        }

        public static User ToUser(UserDTO user)
        {
            return new User
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                PictureURL = user.PictureURL,
                Boosts = user.Boosts,
                Reservations = user.Reservations,
                DateRegistered = user.DateRegistered,
            };
        }
    }
}
