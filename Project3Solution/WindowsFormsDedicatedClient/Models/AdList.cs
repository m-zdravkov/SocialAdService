using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDedicatedClient.SaServicePublic;
using WindowsFormsDedicatedClient.Views;
namespace WindowsFormsDedicatedClient.Models
{
    public static class AdList
    {
        /// <summary>
        /// A method for transforming ads into short-ad user controls ready for displaying
        /// </summary>
        /// <param name="ads">A list of ads</param>
        /// <returns></returns>
        public static ShortAdUserControl[] ToShortAdList(this Ad[] ads)
        {
            var result = new ShortAdUserControl[ads.Length];

            for (int i = 0; i < ads.Length; i++)
            {
                result[i] = new ShortAdUserControl(ads[i]);
            }

            return result;
        }
    }
}
