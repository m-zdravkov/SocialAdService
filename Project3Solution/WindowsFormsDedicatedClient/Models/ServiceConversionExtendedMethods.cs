using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDedicatedClient.SaServicePublic;

namespace WindowsFormsDedicatedClient.Models
{
    /// <summary>
    /// Converts from the reference types of the private to those of the public service
    /// </summary>
    public static class ServiceConversionExtendedMethods
    {
        /// <summary>
        /// Converts an Ad from the private service to an ad from the client.
        /// </summary>
        /// <param name="ad"></param>
        /// <returns></returns>
        public static Ad Convert(this SaServicePrivate.Ad ad)
        {
            return new Ad
            {
                Id = ad.Id,
                Author = ad.Author.Convert(),
                Title = ad.Title,
                Content = ad.Content,
                DatePosted = ad.DatePosted,
                Categories = ad.Categories,
                Type = ad.Type.Convert(),
            };
        }

        public static AdType Convert(this SaServicePrivate.AdType type)
        {
            return (AdType)type;
        }

        /// <summary>
        /// Converts a User from the private service to an ad from the public service.
        /// (Literally no difference apart from reference type).
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static User Convert(this SaServicePrivate.User user)
        {
            return new User
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
                DateRegistered = user.DateRegistered,
                Boosts = user.Boosts,
                Reservations = user.Reservations,
                PictureURL = user.PictureURL,
                //The rest of the properties aren't important or aren't even transmitted
                //through the WCF service.
            };
        }

        /// <summary>
        /// Converts a list of ads from the private service into one of the public service
        /// </summary>
        /// <param name="adList"></param>
        /// <returns></returns>
        public static Ad[] Convert(this SaServicePrivate.Ad[] adList)
        {
            Ad[] converted = new Ad[adList.Length];

            for (int i = 0; i < adList.Length; i++)
            {
                converted[i] = adList[i].Convert();
            }

            return converted;
        }
    }
}
