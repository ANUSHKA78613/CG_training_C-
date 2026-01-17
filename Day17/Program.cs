using System;
using System.Threading;
using System.IO;
class Program
{
      static void PrintMessage(object message)
    {
        Console.WriteLine(message);
    }
    static void DoWork()
    {
        for(int i =1;i <= 5; i++)
        {
            Console.WriteLine("Worker thread: "+i);
        }
    }
    public static async Task Main()
    {
        Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
        thread.Start("hello from thread");
        Thread worker = new Thread(DoWork);
        worker.Start();
        Console.WriteLine("Main thread continuess......");
        Parallel.For(0, 5, i =>
        {
            Console.WriteLine("Processing item" + i);
        });
        int[] numbers = new int[10];
        for(int i = 0; i < numbers.Length; i++)
        
            numbers[i] = i+1;
            int sum = 0;
            // Parallel.For(0,numbers.Length,i =>
            // {
            //     sum += numbers[i];
            // });
        // Console.WriteLine(sum);
        Parallel.For(0,numbers.Length,() => 0,(i,loopState,localSum) => {return localSum + numbers[i];}, localSum => {Interlocked.Add(ref sum,localSum);});
        Console.WriteLine(sum);
      int result =   await GetDataAsync();
      Console.WriteLine(result);
      Console.WriteLine("start reading......");
      string content = await File.ReadAllTextAsync("data.txt");
      Console.WriteLine("file content");
      Console.WriteLine(content);
      Console.WriteLine("End of program");

    }
static async Task<int> GetDataAsync()
    {
        await Task.Delay(1000); // thread is not blocked 
    //    Thread.Sleep(3000); // thread is blocked
        return 42;
    }
  
}