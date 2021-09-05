using System;
using System.Collections.Generic;
using System.Text;

namespace Karat
{
    class Alert_Using_Same_Key_Card
    {
        public IList<string> AlertNames(string[] keyName, string[] keyTime)
        {

            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            for (int i = 0; i < keyName.Length; i++)
            {

                if (!map.ContainsKey(keyName[i]))
                {
                    map.Add(keyName[i], new List<string> { keyTime[i] });
                }
                else
                {
                    var existingList = map[keyName[i]];
                    existingList.Add(keyTime[i]);
                    map[keyName[i]] = existingList;
                }
            }
            List<String> r = new List<String>();
            foreach (var item in map)
            {

                if (!check(map[item.Key]))
                    r.Add(item.Key);
            }
            r.Sort();
            return r;
        }


        private bool check(List<string> list)
        {
            list.Sort();
            for (int i = 2; i < list.Count; i++)
            {
                if (convertToMinutes(list[i]) - convertToMinutes(list[i - 2]) <= 60)
                {
                    return false;
                }
            }
            return true;
        }

        int convertToMinutes(String t)
        {
            String[] x = t.Split(":");
            return Int32.Parse(x[0]) * 60 + Int32.Parse(x[1]);
        }
    }
}
