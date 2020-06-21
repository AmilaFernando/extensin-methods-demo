using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Methods_Demo
{
    public static class NewClass
    {
        public static void MethodThree(this OldClass O)
        {
            Console.WriteLine("Method Three");
        }

        public static void MethodFour(this OldClass O, int x)
        {
            Console.WriteLine("Method Four: " + x);
        }

        public static void MethodFive(this OldClass O)
        {
            Console.WriteLine("Method Five:" + O.x);
        }
    }
}
