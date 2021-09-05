using System;
using System.Collections.Generic;
using System.Text;

namespace Karat
{

    class Friend_Cycle
    {
        string[] employees = new string[] {
                              "1, Bill, Engineer",
                              "2, Joe, HR",
                              "3, Sally, Engineer",
                              "4, Richard, Business",
                              "6, Tom, Engineer"
                            };

        string[] friendships = new string[] {
                              "1, 2",
                              "1, 3",
                              "3, 4" };


        

    }
}
