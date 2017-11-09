using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Model
{
    public static class UserValidator
    {
        private static Regex _nameRegex = new Regex(@"[a-zA-Z]{4,128}");
        private static Regex _passwordRegex = new Regex(@"[a-zA-Z0-9]{8,256}");
        private static Regex _pictureURLRegex = new Regex(@"[a-zA-Z:/.-_]{4,256}");
        private static Regex _emailRegex = new Regex(@"[a-zA-Z0-9_.-][@][.][a-zA-Z]{4,256}");

        public static bool Validate(this User user)
        {
            bool result = true;

            result = result && ValidateName(user.Name);
            result = result && ValidatePassword(user.Password);
            result = result && ValidatePictureURL(user.PictureURL);
            result = result && ValidateBoosts(user.Boosts);
            result = result && ValidateReservations(user.Reservations);
            result = result && ValidateDateRegistered(user.DateRegistered);
            //add any other checks below

            return result;
        }

        private static bool ValidateDateRegistered(DateTime dateRegistered)
        {
            return (dateRegistered != null);
        }

        public static bool ValidateName(string name)
        {
            return _nameRegex.Match(name).Success;
        }

        public static bool ValidatePassword(string hash)
        {
            return _nameRegex.Match(hash).Success;
        }

        public static bool ValidatePictureURL(string url)
        {
            return _pictureURLRegex.Match(url).Success;
        }

        public static bool ValidateBoosts(int value)
        {
            return (value >= 0);
        }

        public static bool ValidateReservations(int value)
        {
            return (value >= 0);
        }
    }
}
