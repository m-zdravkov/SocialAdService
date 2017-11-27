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
        public static bool IsWithin(this Location location, string within)
        {
            return LocationControl.GetInstance().IsWithin(location.Name, within);
        }
    }
}
