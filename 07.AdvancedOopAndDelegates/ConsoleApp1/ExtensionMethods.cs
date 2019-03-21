using System;
using System.Collections.Generic;

namespace ScifiShows
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Filters a string list based on a delegate function used to check each value in the list.
        /// </summary>
        /// <param name="list">The list to be filtered.</param>
        /// <param name="evaluateCondition">The delegate to be invoked when checking each value.</param>
        /// <returns>The filtered string list.</returns>
        public static List<string> FilterList(this List<string> list, Func<string, bool> evaluateCondition)
        {
            List<string> filteredList = new List<string>();

            foreach (string show in list)
                if (evaluateCondition(show))
                    filteredList.Add(show);

            return filteredList;
        }
    }
}
