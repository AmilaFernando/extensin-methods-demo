using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Methods_Demo
{
    public class OldClass
    {
        public int x = 100;

        public void MethodOne()
        {
            Console.WriteLine("Method One: " + this.x);
        }

        public void MethodTwo()
        {
            Console.WriteLine("Method Two: " + this.x);
        }
    }
}
