using System;
using System.Threading;

namespace Lesson8_Practice1_SimpleThreadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(Counting);
            Thread first = new Thread(starter);
            Thread second = new Thread(starter);
            first.Start(); second.Start();
            first.Join(); second.Join();
        }

        static void Counting()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Count: {0} - Thread' {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}
