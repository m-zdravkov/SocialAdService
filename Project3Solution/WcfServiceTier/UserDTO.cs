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
        [DataMember] public string Name { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public string PictureURL { get; set; }
        [DataMember] public int Boosts { get; set; }
        [DataMember] public int Reservations { get; set; }
    }
}
