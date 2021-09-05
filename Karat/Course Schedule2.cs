using System;
using System.Collections.Generic;
using System.Text;

namespace Karat
{
    class Course_Schedule2
    {
        
        public static bool canFinish(int numCourses, int[][] prerequisites)
        {
            // 1st: build directed graph and indegree array
            int n = numCourses;
            int[][] pres = prerequisites;
            // the directed graph
            Dictionary<int, HashSet<int>> graph = new Dictionary<int, HashSet<int>>();
            int[] indegree = new int[n];

            for (int i = 0; i < n; i++) graph.Add(i, new HashSet<int>());

            foreach (var pre in pres)
            {
                int child = pre[0];
                int parent = pre[1];
                // 注意这里是parent : children 形式
                graph.GetValueOrDefault(parent).Add(child);
                indegree[child]++;
            }
            // BFS topological sort
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                if (indegree[i] == 0) q.Enqueue(i);
            }
            int count = 0;
            while (q.Count>0)
            {
                int cur = q.Dequeue();
                count++;
                foreach (int child in graph.GetValueOrDefault(cur))
                {
                    indegree[child]--;
                    if (indegree[child] == 0) q.Enqueue(child);
                }
            }
            return count == n;
        }


        public static int[] findOrder(int numCourses, int[][] prerequisites)
        {
            List<List<int>> dpList = new List<List<int>>();

            for (int i = 0; i < numCourses; ++i)
            {
                dpList.Add(new List<int>());  // dpList[0] is for course 0, and dpList[i] for course i 
            }

            // get dependency list and indegree
            int[] indegree = new int[numCourses];
            for (int i = 0; i < prerequisites.Length; ++i)
            {

                int[] tmpDep = new int[2] { prerequisites[i][0], prerequisites[i][1] }; // add some explanation variable to smooth reading

                dpList[tmpDep[1]].Add(tmpDep[0]);  // (0,1) -> take 0 first, and then take 1 
                ++indegree[tmpDep[0]];             // 0 node adds one more indegree from 1 
            }

            // add thoes course first with 0 indegree 
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < numCourses; ++i)
            {
                if (indegree[i] == 0)
                    q.Enqueue(i);
            }

            // take courses
            int[] result = new int[numCourses];
            int count = 0;
            while (q.Count > 0)
            {  // always start from node with indegree value 0 <- make sense 
               // dependency list of node <- course only can be taken after the current node
                int toTake = q.Dequeue();
                result[count++] = toTake;   // increment count value <-- use to check if ordering is available at the end

                foreach (int c in dpList[toTake])
                {
                    --indegree[c];    // decrement value of indegree by 1 

                    if (indegree[c] == 0)   // check if node c is ready to add to queue <- no indegree 
                        q.Enqueue(c);
                }
            }

            if (count != numCourses)
                return new int[0]; // haven't taken all courses

            return result;
        }
    }
}
