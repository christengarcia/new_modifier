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

    class TEST1 : TEST
    {
        public new void Func()
        {
            Console.WriteLine("TEST1.func");
        }
    }
}
