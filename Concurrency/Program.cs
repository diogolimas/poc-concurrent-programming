using System;
using System.Threading;


namespace Concurrency
{
    class Program
    {
        static void Main()
        {
            Thread x = new Thread(ThreadOneExecution); // create a new thread
            x.Start(); 
            // at the same time, we perform operations in the main  thread
            Thread y = new Thread(ThreadTwoExecution); // create a new thread
            y.Start();
            Thread z = new Thread(ThreadThreeExecution); // create a new thread
            z.Start();

            for (int i = 0; i < 1000; i++) Console.Write("after | ");

            Console.ReadKey();
        }
        static void ThreadOneExecution()
        {
            for (int i = 0; i < 2000; i++) Console.Write("thread 1 | ");
        }
        static void ThreadTwoExecution()
        {
            for (int i = 0; i < 3000; i++) Console.Write("thread 2 | ");
        }
        static void ThreadThreeExecution()
        {
            for (int i = 0; i < 4000; i++) Console.Write("thread 3 | "); 
        }
    }


    class Program2
    {
        static void Main()
        {
            Thread x = new Thread(ThreadOneExecution); // create a new thread
            x.Start();
            x.Join();
            Thread y = new Thread(ThreadTwoExecution); // create a new thread
            y.Start();
            y.Join();   
            Thread z = new Thread(ThreadThreeExecution); // create a new thread
            z.Start();
            z.Join();

            for (int i = 0; i < 1000; i++) Console.Write("after | ");

            Console.ReadKey();
        }
        static void ThreadOneExecution()
        {
            for (int i = 0; i < 2000; i++) Console.Write("1");
        }
        static void ThreadTwoExecution()
        {
            for (int i = 0; i < 3000; i++) Console.Write("2");
        }
        static void ThreadThreeExecution()
        {   
            for (int i = 0; i < 4000; i++) Console.Write("3");
        }
    }


    class Program3
    {
        static void Main()
        {
            Thread t = new Thread(() => paramMethod("executing a thread"));
            t.Start();

            Console.ReadKey();
        }
        static void paramMethod(string text)
        {
            Console.WriteLine(text);
        }
    }

}