using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Thread no:{Thread.CurrentThread.ManagedThreadId}");

            Task task1 = new Task(Process1);
            task1.Start();

            Process2();
            Console.ReadKey();

        }

        static void Process2()
        {
            Console.WriteLine("2.işleme başladım");
            Console.WriteLine($"Thread no:{Thread.CurrentThread.ManagedThreadId}");
        }

        static void Process1()
        {
            Console.WriteLine("1. işleme başladım");
            Console.WriteLine($"Thread no:{Thread.CurrentThread.ManagedThreadId}");
        }
    }

}
