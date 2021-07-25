using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft
{
    public class Group_Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> groupedAnagrams = new List<IList<string>>();
            Dictionary<string, List<string>>
                map = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] current = strs[i].ToCharArray();
                Array.Sort(current);
                string sortedString = new string(current);
                if (!map.ContainsKey(sortedString))
                {
                    map.Add(sortedString, new List<string>() { strs[i] });
                }
                else
                {
                    var sortedList = map[sortedString];
                    sortedList.Add(strs[i]);
                    map[sortedString] = sortedList;
                }
            }

            foreach (var val in map.Values)
            {
                groupedAnagrams.Add(val);
            }
           
            return groupedAnagrams;
        }
    }
}
