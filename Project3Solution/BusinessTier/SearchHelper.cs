using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessTier
{
    public static class SearchHelper
    {
        /// <summary>
        /// Prepares a query for searching. Turns it into a list of keywords
        /// </summary>
        /// <returns></returns>
        public static IList<string> GetKeywords(this String query)
        {
            query = query.ToLower();

            //Keep only alphanumeric symbols and spaces
            Regex rgx = new Regex("[^a-zA-Z0-9 ]");
            query = rgx.Replace(query, " ");

            //Split the string into a list of strings on each space
            IList<string> keywords = query.Split(' ').ToList();
            keywords.FilterOutSearchWords();

            return keywords;
        }

        /// <summary>
        /// Remove some very common unneccessary words like prepositions to
        /// optimize the search a little. Sometimes people write a lot of
        /// descriptive words that the alghorithm can not use properly or doesn't need.
        /// These could save a lot of database overhead.
        /// </summary>
        /// <returns></returns>
        public static IList<string> FilterOutSearchWords(this IList<string> list)
        {
            string[] blacklist = { "a", "an" , "that", "i", "you", "it", "we", "they",
                "use", "for", "in", "there", "order", "to", "need", "want", "like", "looking" };

            foreach (var word in list)
            {
                if (blacklist.Contains(word))
                    list.Remove(word);
            }

            return list;
        }
    }
}
