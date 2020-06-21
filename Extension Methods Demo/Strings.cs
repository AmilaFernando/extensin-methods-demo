using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Methods_Demo
{
    public static class Strings
    {
        public static string ToSimpleCapital(this string str)
        {
            return str.ToLower() + "-" + str.ToUpper();
        }
    }
}
