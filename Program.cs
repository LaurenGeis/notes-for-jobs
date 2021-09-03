// imports at very top
using System;


namespace Test  // project name
{
    class Program   // class container 
    {
        static void Main(string[] args)     // main method 
        {
            Console.WriteLine("This is a C# test, for notes on C#");  // Console.WriteLine is the print function in C# 
            

            int index = 1;
            while (index <= 5)  // while loop test
            {
                Console.WriteLine(index);
                index++;
            }

            Console.ReadLine(); // keeps console open
        }
    }
}
