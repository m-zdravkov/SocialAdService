using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Model
{
    public static class PostValidator
    {
        private static Regex _contentRegex = new Regex(@"[a-zA-Z]{4,128}");
        //TO DO: Test if the Regex for URLS works.
        private static Regex _imageSourceRegex = new Regex(@"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$");

        public static Comment postObject { get; set; }
        

        public static bool ValidatePost (this Comment post)
        {
            bool result = true;

            result = result && validateContent(postObject.Content);
            result = result && validateImageSource(postObject.ImageSource);

            return result;
        }

        public static bool validateContent (string content)
        {
            return _contentRegex.Match(content).Success;
        }

        public static bool validateImageSource (string imageSource)
        {
            return _imageSourceRegex.Match(imageSource).Success;
        }
    }
}
