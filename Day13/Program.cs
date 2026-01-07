using System;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;
using EcommerceAssessment;
using  CallbackDemo;
class Program
{
    public static void Main()
    {
        PaymentServices service = new PaymentServices();
       // PaymentDelegate payment = service.ProcessPayment;  /single delegate
       // decimal amount = 5000;
        // if (amount.IsValidPayment())
        // {
        //      payment(amount);
        // }
        // else
        // {
        //     Console.WriteLine("Invalid input");
        // }
    //    PaymentDelegate payment = null;            //  multiple calls using single delegate
    //    payment += service.ProcessPayment;
    //    payment += service.Rtgs;
    //    payment(5000);
    // Action<string> logActivity = message => Console.WriteLine("log entry: "+message); // action delegate = no return type
    // logActivity("user logged in at 10:30AM");
    //-----Function delegate-----
    // Func<decimal,decimal,decimal> Fac = (price,discount) => price-(price*discount/100); 
    // Console.WriteLine(Fac(1000,10));
    // Predicate<int> pp = age => age >= 18;  // predicate return bool and take 1 paramter
    // Console.WriteLine(pp(20));

   // Button btn = new Button();
    // btn.Clicked += () => Console.WriteLine("Button clicked");
    // btn.Clicked += () => Console.WriteLine("On hovered");
    // btn.Click();

    // Objects Initialization
            // MotionSensor livingRoomSensor = new MotionSensor();
            // AlarmSystem siren = new AlarmSystem();
    //         PoliceNotifier police = new PoliceNotifier();

    //         // 2. INSTANTIATION & MULTICASTING
    //         // We "Subscribe" different methods to the sensor's delegate
    //         SecurityAction panicSequence = siren.SoundSiren; // Assignment of methods
    //         panicSequence += police.CallDispatch;

    //         // Linking the sequence to the sensor
    //         livingRoomSensor.OnEmergency = panicSequence;
	// // class_object.delegate_instance = delegate_instance_multicast

    //         // Simulation
    //         livingRoomSensor.DetectIntruder("Main Lobby");

        //  static void DisplayNotification(string file)
        // {
        //     Console.WriteLine($"NOTIFICATION: You can now open {file}.");
        // }

      
        //     FileDownloader downloader = new FileDownloader();

        //     // Pass the method 'DisplayNotification' as a callback
        //     downloader.DownloadFile("Presentation.pdf", DisplayNotification);
        
        // Comparison<int>sortDescending = (a,b) => b.CompareTo(a); // <int> parameters type
        // Console.WriteLine(sortDescending(5,10));
        // --------------------------------------------------------------------------------------------------------------------

        // 1 - H o u r  A s s i g n m e n t---------------------------------------------------------------
            Repository<Order> orderRepository = new Repository<Order>();
            orderRepository.Add(new Order { OrderId = 1, CustomerName = "Alice", Amount = 5000 });
            orderRepository.Add(new Order { OrderId = 2, CustomerName = "Bob", Amount = 2000 });
            orderRepository.Add(new Order { OrderId = 3, CustomerName = "Charlie", Amount = 8000 });
            Func<double, double> taxCalculator = amount => amount * 0.18;
            Func<double, double> discountCalculator = amount => amount * 0.05;
            Predicate<Order> validator = order => order.Amount >= 3000;
              OrderCallback callback = message =>
            {
                Console.WriteLine("Callback: " + message);
            };
            Action<string> logger = msg => Console.WriteLine("Logger: " + msg);
            Action<string> notifier = msg => Console.WriteLine("Notifier: " + msg);
             OrderProcessor processor = new OrderProcessor();
            processor.OrderProcessed += logger;
            processor.OrderProcessed += notifier;
    
             foreach (var order in orderRepository.GetAll())
            {
                processor.ProcessOrder(
                    order,
                    taxCalculator,
                    discountCalculator,
                    validator,
                    callback
                );
                Console.WriteLine();
            }
             List<Order> orders = orderRepository.GetAll();
            orders.Sort((o1, o2) => o2.Amount.CompareTo(o1.Amount));
               Console.WriteLine("Sorted Orders (Descending Amount):");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
}
}