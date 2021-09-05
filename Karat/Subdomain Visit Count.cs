using System;
using System.Collections.Generic;
using System.Text;

namespace Karat
{
    class Subdomain_Visit_Count
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var domain in cpdomains)
            {
                string[] domainandhits = domain.Split(" ");
                int hits = domainandhits[0] == null ? 0 : Convert.ToInt32(domainandhits[0]);
                string curr = domainandhits[1];


                while (!String.IsNullOrEmpty(curr))
                {

                    int existingCount = 0;
                    counts.TryGetValue(curr, out existingCount);

                    bool isAdded = counts.TryAdd(curr, existingCount + hits);
                    if (!isAdded)
                        counts[curr] = existingCount + hits;

                    int index = curr.IndexOf(".");
                    if (index > -1)
                    {

                        curr = curr.Substring(index + 1);
                    }
                    else
                    {
                        curr = "";
                    }

                }


                /* while (!String.IsNullOrEmpty(curr))
                 {
                     int existingCount = 0;
                     counts.TryGetValue(curr, out existingCount);
                     bool isExist = counts.TryAdd(curr, existingCount + hits);
                     if (!isExist)
                         counts[curr] = existingCount + hits;

                     int index = curr.IndexOf(".");

                     if (index > -1)
                     {
                         curr = curr.Substring(index + 1);
                     }
                     else
                     {
                         curr = "";
                     }

                 } */

            }

            List<string> ans = new List<string>();
            foreach (var item in counts)
            {
                string toAdd = item.Value + " " + item.Key;

                ans.Add(toAdd);
            }

            return ans;


        }
    }
}
