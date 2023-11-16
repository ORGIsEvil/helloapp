using System;

namespace Helloapp
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("hello everyone");
            GetPrivet();
            GetPrivetBlack();
        }

        static void GetPrivet ()
        {
            Console.WriteLine("hello white");
        }

        static void GetPrivetBlack ()
        {
            Console.WriteLine("hello black");
        }

    }
}