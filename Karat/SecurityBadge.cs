using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karat
{
    public static class SecurityBadge
    {
        static string[,] securityRecord = new string[,] {
{ "Martha", "exit"},
{"Paul", "enter"},
{"Martha", "enter"},
{ "Martha", "exit"},
{ "Jennifer", "enter"},
{ "Paul", "enter"},
{ "Curtis", "exit"},
{ "Curtis", "enter"},
{ "Paul", "exit"},
{ "Martha", "enter"},
{ "Martha", "exit"},
{ "Jennifer", "exit"},
{ "Paul", "enter"},
{ "Paul", "enter"},
{ "Martha", "exit"},
};
        public static void find_mismatched()
        {
            String[,] records = securityRecord;
            Dictionary<string, int> map = new Dictionary<string, int>();
            HashSet<string> invalidEnter = new HashSet<string>();
            HashSet<string> invalidExit = new HashSet<string>();
            for (int i = 0; i < records.GetLength(0); i++)
            {
                var person = records[i, 0];
                string action = records[i, 1];
                int getval = 0;
                map.TryGetValue(person, out getval);
                int curState = getval;

                if (action == "enter")
                {
                    if (curState == 1)
                    {
                        // invalid login
                        invalidEnter.Add(person);
                    }
                    map[person] = 1;
                }
                else
                {
                    if (curState == 0)
                    {
                        // invalid login
                        invalidExit.Add(person);
                    }
                    map[person] = 0;

                }
            }

            foreach (var item in map.Keys)
            {
                if (map[item] == 1)
                    invalidEnter.Add(item);
            }

            Console.WriteLine($"Invalid Enter: { string.Concat(invalidEnter.Select(x => x + ", ")) }");

            Console.WriteLine($"Invalid Exit: { string.Concat(invalidExit.Select(x => x + ", ")) }");



        }


        public static void find_mismatched1( )
        {
            String[,] records = securityRecord;
            HashSet<String> a = new HashSet<string>();
            HashSet<String> b = new HashSet<String>();
            //  Map to store the state 0:outside of the room 1: inside the room
            Dictionary<String, int> map = new Dictionary<string, int>();

            //            foreach (var record in records.)
            for (int i = 0; i < records.GetLength(0); i++)
            {
                String person = records[i, 0];
                String action = records[i, 1];
                int getval = 0;
                map.TryGetValue(person, out getval);
                int curState = getval;
                if ((action == "enter"))
                {
                    if ((curState == 1))
                    {
                        a.Add(person);
                    }

                    map[person] = 1;
                }
                else
                {
                    if ((curState == 0))
                    {
                        b.Add(person);
                    }

                    map[person] = 0;
                }

            }

            foreach (var entry in map.Keys)
            {
                if ((map[entry] == 1))
                {
                    a.Add(entry);
                }

            }

            Console.WriteLine(("who didn\'t use their badge while exiting the room: " + a));
            Console.WriteLine(("who didn\'t use their badge while entering the room: " + b));
        }
    }
}
