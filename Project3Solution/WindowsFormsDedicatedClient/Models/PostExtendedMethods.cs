using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDedicatedClient.SaServicePublic;
using WindowsFormsDedicatedClient.Views;
namespace WindowsFormsDedicatedClient.Models
{
    public static class PostExtendedMethods
    {
        /// <summary>
        /// A method for transforming ads into short-ad user controls ready for displaying
        /// </summary>
        /// <param name="ads">A list of ads</param>
        /// <returns></returns>
        public static ShortAdUserControl[] ToShortAdUcList(this Ad[] ads)
        {
            var result = new ShortAdUserControl[ads.Length];

            for (int i = 0; i < ads.Length; i++)
            {
                result[i] = new ShortAdUserControl(ads[i]);
            }

            return result;
        }

        /// <summary>
        /// A method for transforming comments into comment user controls ready for displaying
        /// </summary>
        /// <param name="comments">A list of comments</param>
        /// <returns></returns>
        public static CommentUserControl[] ToCommentUcList(this Comment[] comments)
        {
            var result = new CommentUserControl[comments.Length];

            for (int i = 0; i < comments.Length; i++)
            {
                result[i] = new CommentUserControl(comments[i]);
            }

            return result;
        }
    }
}
