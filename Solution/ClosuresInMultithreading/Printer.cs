using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClosuresInMultithreading
{
    public class Printer
    {
        /*
         * 
         * In theory, this program should work: you
         * expect the program to print the numbers 1 to 10. But in practice, this isn’t the case; the
         * program will print the number 10 ten times, because you’re using the same variable in
         * several lambda expressions, and these anonymous functions share the variable value.
         * 
        */
        public void Print() {
            Console.WriteLine("Printing...");
            for (int iteration = 1; iteration < 1000; iteration++)
            {
                Console.WriteLine("- Thread : {0} \t - iteration :  {1}", Thread.CurrentThread.ManagedThreadId, iteration);
            }
            Console.WriteLine();
        }

        public void PrintMultithreaded()
        {
            Console.WriteLine("Printing Multithreaded...");
            for (int iteration = 1; iteration < 1000; iteration++)
            {
                Task.Factory.StartNew(() => Console.WriteLine("- Thread : {0} \t - iteration :  {1}", Thread.CurrentThread.ManagedThreadId, iteration));
            }
        }        
    }
}
