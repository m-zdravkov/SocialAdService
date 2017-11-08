using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Model
{
    public class UserValidator
    {
        private static Regex _nameRegex = new Regex(@"[a-zA-Z]{4,128}");

        public User User { get; set; }

        public UserValidator(User user)
        {
            User = user;
        }

        public bool ValidateUser()
        {
            bool result = true;

            result = result && ValidateName(User.Name);
            //result = result && ValidateName(User.Name);
            //result = result && ValidateName(User.Name);
            //result = result && ValidateName(User.Name);
            //other checks
            return result;
        }


        public static bool ValidateName(string name)
        {
            return _nameRegex.Match(name).Success;
        }

        
    }
}
