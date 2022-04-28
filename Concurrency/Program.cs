using System;
using System.Threading;
using System.Threading.Tasks;

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

    class Program4
    {
        static void Main()
        {
            Task task = Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Inicializando uma Task");
            });

            Console.WriteLine("task is completed: " + task.IsCompleted);
            task.Wait(); 
            Console.WriteLine("task is completed after inicialization: " + task.IsCompleted);
 
             Console.ReadKey();
        }
    }

    class Program5
    {
        static void Main()
        {
            Task<int> task = Task.Run(() =>         
            {
                return 3;
            });

            int number = task.Result;

            Console.WriteLine(number);

            Console.ReadKey();
        }
    }

    class Program6
    {
        static void Main()
        {
            Task<int> primeNumberTask = Task.Run(() =>
            {
                Thread.Sleep(3000);
                return 10;
            });

            var awaiter = primeNumberTask.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                int result = awaiter.GetResult();
                Console.WriteLine(result); 
            });

            Console.ReadKey();
        }
    }

    class Program7
    {
        static void Main()
        {
            Task<int> primeNumberTask = Task.Run(() =>
            {
                Thread.Sleep(3000);
                return 10;
            });

            primeNumberTask.ContinueWith(antecedent =>
            {
                int result = antecedent.Result;
                Console.WriteLine(result); 
            });

            Console.ReadKey();
        }
    }

    class Program8
    {
        static void Main()
        {
            Task.Delay(3000).GetAwaiter().OnCompleted(() => Console.WriteLine("My task is completed " +
                "after 3 seconds! :)"));
            Console.ReadKey();
        }
    }

}