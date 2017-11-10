using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Model
{
    public static class LocationValidator
    {
        public static Regex _nameRegex = new Regex(@"[a-zA-Z]{4,128}");

        public static Location locationObj { get; set; }

        public static bool ValidateLocation (this Location location)
        {
            bool result = true;

            result = result && ValidateName(location.name);

            return result;
        }

        public static bool ValidateName (string name)
        {
            return _nameRegex.Match(name).Success;
        }
    }
}
