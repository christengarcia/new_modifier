/*
 *  C# Program to Demonstrate New modifier
 */

using System;

namespace new_modifier
{
    class Test
    {
        public void Func()
        {
            Console.WriteLine("TEST.func");
        }
    }

    class TEST1 : Test
    {
        public new void Func()
        {
            Console.WriteLine("TEST1.func");
        }
    }

    class Program
    {
        static void Main()
        {
            Test ref1 = new Test();
            Test ref2 = new TEST1();
            TEST1 ref3 = new TEST1();

            ref1.Func();
            ref2.Func();
            ref3.Func();
            Console.Read();
        }
    }
}
