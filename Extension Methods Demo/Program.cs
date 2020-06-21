using System;

namespace Extension_Methods_Demo
{
    public static class Program
    {
        static void Main(string[] args)
        {
            OldClass obj1 = new OldClass();

            obj1.MethodOne();
            obj1.MethodTwo();
            obj1.MethodThree();
            obj1.MethodFour(10);
            obj1.MethodFive();

            string str = "AbCdEfGhIjK";

            Console.WriteLine("String is : {0}",  str);

            Console.WriteLine(str.ToSimpleCapital());

            Console.ReadLine();
        }
    }
}
