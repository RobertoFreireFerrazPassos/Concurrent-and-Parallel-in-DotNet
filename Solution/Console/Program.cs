using ClosuresInMultithreading;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            RunPrintMultithreadedExample();
            Console.ReadKey();
        }

        public static void RunPrintMultithreadedExample() 
        {
            var printer = new Printer();

            printer.Print();
            printer.PrintMultithreaded();
        }
    }
}
