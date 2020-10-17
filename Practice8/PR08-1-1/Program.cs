﻿using System;
using System.Threading;

namespace PR08_1_1
{
    class Program
    {
        static void Counting()
        {
            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine("Count: {0} - Thread {1}", i , Thread.CurrentThread.ManagedThreadId); 
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(Counting);
            Thread first = new Thread(starter);
            Thread second = new Thread(starter);
            first.Start(); second.Start();
            first.Join(); second.Join();
            Console.Read();
        }
    }
}
