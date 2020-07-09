using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadSheetReview
{
    public static class User
    {
        public static string FirstName { get; set; }
        
        public static void PrintName()
        {
            Console.WriteLine(FirstName);
        }
    }
}
