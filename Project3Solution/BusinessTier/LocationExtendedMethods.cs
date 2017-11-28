using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public static class LocationExtendedMethods
    {
        public static Location GetLocationObject(this string location, ServiceDbContext context = null)
        {
            if(context == null)
                return LocationControl.GetInstance().GetLocation(location);
            else
                return LocationControl.GetInstance().GetLocation(context, location);
        }

        public static bool IsWithin(this Location location, string within)
        {
            return LocationControl.GetInstance().IsWithin(location.Name, within);
        }

        public static IList<Location> GetParents(this Location location, bool locationIsAlreadyValidated = false)
        {
            return LocationControl.GetInstance().GetParents(location, locationIsAlreadyValidated);
        }

        public static IList<string> ToNameList(this IList<Location> locations)
        {
            var list = new List<string>();
            foreach (var item in locations)
            {
                list.Add(item.Name);
            }
            return list;
        }

        public static IList<Location> GetChildren(this Location location, bool locationIsAlreadyValidated = false)
        {
            return LocationControl.GetInstance().GetChildren(location, locationIsAlreadyValidated);
        }
    }
}
