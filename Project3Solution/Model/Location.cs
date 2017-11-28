using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public enum LocationType { Country, Region, City, Area, Address }

    public class Location
    {   
        [Key]
        [StringLength(256)]
        public string Name { get; set; }
        public LocationType Type { get; set; }
        public Location Parent { get; set; }
    }
}
