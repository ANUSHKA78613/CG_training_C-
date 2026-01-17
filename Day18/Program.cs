// using System;
using System.Diagnostics;
// class Program
// {
//     static void Main()
//     {
//      Process curr = Process.GetCurrentProcess();
//      Console.WriteLine("current process id:" + curr.Id);
//      Console.WriteLine("current process id:" + curr.ProcessName);
//      Console.WriteLine("current process id:" + curr.StartTime);
//      Console.WriteLine("current process id:" + curr.Threads);
//      Console.WriteLine("current process id:" + curr.TotalProcessorTime);

//     }
// }
using System;
using System.Threading;

class Program
{
    // static int c = 0;
    // static object lockObj = new object();
    // static void Increment()
    // {
    //     for(int i = 0; i < 100000; i++)
    //     {
    //          lock (lockObj)
    //         {
    //             c++;
    //         }
    //     }
    // }
   public static void Main()
    {
        // // Create a new thread
        // Thread worker = new Thread(DoWork);

        // // Start the thread
        // worker.Start();

        // Console.WriteLine("Main thread continues...");

        // // Optional: Wait for worker thread to finish
        // worker.Join();
        // Console.WriteLine("Main thread finished");
        // // Process.Start("notepad.exe");
        // Process.Start("cmd.exe");
        // Thread t1 = new Thread(Increment);
        // Thread t2 = new Thread(Increment);
        // t1.Start();
        // t2.Start();
        // t1.Join();
        // t2.Join();
        // Console.WriteLine(c);
      //  try
        // {
        //     Task t = Task.Run(() => throw new Exception("task error"));
        //     t.Wait();
        // }
        // catch(AggregateException ex)
        // {
        //     Console.WriteLine(ex.InnerExceptions[0].Message);
        // }
        // Task t1 = Task.Run(() => Console.WriteLine("Task 1"));
        // Task t2 = Task.Run(() => Console.WriteLine("Task 2"));
        // Task. WhenAll(t1, t2).ContinueWith(t => Console.WriteLine("All tasks completed"));
        // Console.WriteLine();
       Task<int> t = Task.Run(() => 42);

t.ContinueWith(resultTask =>{Console.WriteLine("Result: " + resultTask.Result);}).Wait();
// t.Wait();
    }

    // static void DoWork()
    // {
    //     for (int i = 1; i <= 5; i++)
    //     {
    //         Console.WriteLine("Worker thread: " + i);
    //         Thread.Sleep(500); // Simulate work
    //     }
    // }


}