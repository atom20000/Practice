﻿using System;
using System.Threading;

namespace PR08_3_1
{
    class Program
    {
        static void ShowMyText(object state)
        {
            string myText = (string)state;
            Console.WriteLine("Thread: {0} - {1}",Thread.CurrentThread.ManagedThreadId, myText);
        }
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(callback, "Hello");
            ThreadPool.QueueUserWorkItem(callback, "Hi");
            ThreadPool.QueueUserWorkItem(callback, "Heya");
            ThreadPool.QueueUserWorkItem(callback, "Goodbye");
            Console.Read();
        }
    }
}
