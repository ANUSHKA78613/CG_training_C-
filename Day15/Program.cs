using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
// class Program
// {
//     public static void Main()
//     {
//         Trace.Listeners.Add(new ConsoleTraceListener()); // print trace output iin console
//         Trace.WriteLine("application started");
//         int a = 20,b = 0;
//         try
//         {
//             int result = a/b;
//             Console.WriteLine(result);
//         }
//         catch(Exception ex)
//         {
//             Trace.WriteLine("Exception occured"+ex.Message);
//         }
//         Trace.WriteLine("application ended");
//     }
// }
    //     Trace.Listeners.Add(new ConsoleTraceListener());

    //     Trace.WriteLine("Program started");

    //     PerformCalculation(10, 5);
    //     PerformCalculation(10, 0);   // Error case

    //     Trace.WriteLine("Program ended");
    // }

    // static void PerformCalculation(int a, int b)
    // {
    //     Trace.WriteLine($"Entering PerformCalculation | a={a}, b={b}");

    //     if (b == 0)
    //     {
    //         Trace.WriteLine("Error: Division by zero detected");
    //         return;
    //     }

    //     int result = Divide(a, b);

    //     Trace.WriteLine($"Calculation successful | Result={result}");
    //     Trace.WriteLine("Exiting PerformCalculation");
    // }

    // static int Divide(int x, int y)
    // {
    //     Trace.WriteLine($"Dividing values | x={x}, y={y}");
    //     return x / y;
  //  int total = 0;
    // for(int i=0;i<= 5; i++)
    //     {
    //         total += i;
    //     }
    //     Console.WriteLine(total);

//   int[] a = {23,45,33,55,66,60,44};
//   foreach(int i in a)
//         {
//             if(i > 60)
//             {
//             Console.WriteLine(i);
//             }
//         }
// List<User> users = new List<User>();

//         users.Add(new User{Name = "Aryan", Age = 22});
//         users.Add(new User{Name = "Mohit", Age = 32});
//         users.Add(new User{Name = "Sushant", Age = 68});
//         users.Add(new User{Name = "Ritik", Age = 63});
//         users.Add(new User{Name = "Sahil", Age = 52});

//         foreach(var user in users)
//         {
//             Console.WriteLine($"User Name: {user.Name}, User Age: {user.Age}");
//         }

//         Queue<int> queue = new Queue<int>();
//         queue.Enqueue(45);
//         queue.Enqueue(55);
//         queue.Enqueue(65);
//         queue.Enqueue(75);
//         queue.Enqueue(25);

//         while(queue.Count > 0)
//         {
//             Console.Write(queue.Dequeue() + " ");
//         }
//  class Program
// {
//     static void Main(string[] args)
//     {
// List<Student> students = new List<Student>
// {
//     new Student { Name = "Aman", Marks = 75 },
//     new Student { Name = "Riya", Marks = 485 },
//     new Student { Name = "Rahul", Marks = 62 }
// };
//   var result = students.Select(s => new
// {
//     s.Name,
//     Grade = s.Marks > 60 ? "Pass" : "Fail"
// });
// Console.WriteLine(result.GetType());
// var sorted = students.OrderByDescending(e => e.Marks).ThenBy(e => e.Name);
// foreach(var i in sorted)
//         {
// Console.WriteLine(i.Name + "=" + i.Marks);
//         }
// Console.WriteLine(sorted.GetType());
    
    // List<int>numbers = new List<int>{10,20,30};
    // Console.WriteLine(numbers.First());
    // int result = numbers.First(n => n > 15);
    // Console.WriteLine(result);
// }
// }
// class User
//     {
//         public string Name {get; set;}
//         public int Age {get; set;}
//     }
// ------------------------------------Assignment.cs----------------------------------------------

class Program
{
    public static void Main()
    {
        List<SensorReadings> sensorHistory = new List<SensorReadings>
        {
            new SensorReadings{SensorId = 1,Type = "Distance",Value = 0,Confidence = 0, TimeStamp = DateTime.Now.AddSeconds(-5)},
            new SensorReadings{SensorId = 2,Type = "Battery",Value = 18,Confidence = 0.8, TimeStamp = DateTime.Now.AddSeconds(-8)},
            new SensorReadings{SensorId = 3,Type = "Distance",Value = 0,Confidence = 0, TimeStamp = DateTime.Now.AddSeconds(-12)},
            new SensorReadings{SensorId = 4,Type = "Vibration",Value = 8.2,Confidence = 0.6, TimeStamp = DateTime.Now.AddSeconds(-20)},
            new SensorReadings{SensorId = 5,Type = "Battery",Value = 75,Confidence = 0.6, TimeStamp = DateTime.Now.AddSeconds(-3)},
            new SensorReadings{SensorId = 6,Type = "Distance",Value = 0,Confidence = 0, TimeStamp = DateTime.Now.AddSeconds(-15)},
        };
        DateTime fromTime = DateTime.Now.AddSeconds(-10);
        DecisionEngine decisionEngine = new DecisionEngine();
        List<SensorReadings> recentReadings = decisionEngine.GetRecentReadings(sensorHistory,fromTime);
        foreach (var reading in recentReadings)
        {
            Console.WriteLine(
                $"SensorId: {reading.SensorId}, Type: {reading.Type}, Time: {reading.TimeStamp}");
        }    
        // task 2
        bool t = decisionEngine.IsBatteryCritical(sensorHistory);
       Console.WriteLine(t);

       // task 3
       double s = decisionEngine.GetNearestObstacleDistance(sensorHistory);
       Console.WriteLine(s);
       // task 4
    bool tt = decisionEngine.IsTemperatureSafe(sensorHistory);
       Console.WriteLine(tt);
       // task 5
          double sss = decisionEngine.GetAverageVibration(sensorHistory);
       Console.WriteLine(sss);
       // task 6
       Dictionary<string,double> dict = decisionEngine.CalculateSensorHealth(sensorHistory);
       foreach(var d in dict)
        {
            Console.WriteLine($"{d.Key} -> {d.Value:F2}");
        }
        // task 7
        List<string> l = decisionEngine.DetectFaultySensors(sensorHistory);
        foreach(string i in l)
        {
            Console.WriteLine(i);
        }
        // task 9
        double dddd = decisionEngine.GetWeightedDistance(sensorHistory);
        Console.WriteLine(dddd);
       RobotAction ra = decisionEngine.DecideRobotAction(recentReadings,sensorHistory);
       Console.WriteLine(ra);
        }
}