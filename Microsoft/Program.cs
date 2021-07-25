using System;

namespace Microsoft
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] multidimensionarray = new int[3][] {
new int[3]{ 1,1,1},
new int[3]{ 1,0,1},
new int[3]{ 1,1,1}
            };

            //multidimensionarray[0,1] = 1;
            //multidimensionarray[0, 2] = 1;
            //multidimensionarray[0, 2] = 1;

            //multidimensionarray[1, 1] = 1;
            //multidimensionarray[1, 2] = 0;
            //multidimensionarray[1, 2] = 1;

            //multidimensionarray[2, 1] = 1;
            //multidimensionarray[2, 2] = 1;
            //multidimensionarray[2, 2] = 1;


            Set_Matrix_Zeroes.SetZeroes(
               multidimensionarray

                );

            Console.WriteLine("Hello World!");
        }
    }
}
