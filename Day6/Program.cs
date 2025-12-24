using System;
class Program
{
    // this keyword =  refers to current object
    static void ProcessTrade(Trad trade)
{
    if (trade is EquityTrad eq)
    {
        Console.WriteLine("Processing Equity Trade");

        double tradeValue = eq.Calcu();
        Console.WriteLine("Trade Value: " + tradeValue);
        Console.WriteLine("Brokerage: " + tradeValue.Brokerage(0.1));
        Console.WriteLine("GST: " + tradeValue.GST(0.018));

        Console.WriteLine(eq.ToString());
        Console.WriteLine(); // blank line between trades
    }
}

    public static void Main()
    {
    //     StockPrice sp = new StockPrice
    //     {
    //         symbol = "AAPL",price = 150.50
    //     };
    //     StockPrice cp = sp;
    //     cp.price = 155.00;
    //     Console.WriteLine(sp.price); // original value ( by value)
    //     Console.WriteLine(cp.price); // copied value
    //     // Trade t = new Trade
    //     // {
    //     //     trade_id=101,symbol="TCS",quantity=3
    //     // };
    //     // Trade tr = t;
    //     // tr.quantity=200;
    //     //  Console.WriteLine(t.quantity); // original(by reference)
    //     // Console.WriteLine(tr.quantity); // original

    //     Portfolio p1 = new Portfolio{ Name = "Growth"};
    //     Portfolio p2 = new Portfolio{ Name = "Growth"};
       
    //     Console.WriteLine(p1.Equals(p2));  // value check krega
    //   //  Console.WriteLine(p1 == p2); // will return false (memory check krega)
    //     Console.WriteLine(p1.GetHashCode());
    //     Console.WriteLine(p2.GetHashCode());

    //     //   Trade t = new EquityTrade();  
    //     // Console.WriteLine(t.GetType()); //return object datatype
    //     // // GENERIC.CS // WORK WITH CATEGORICAL DATATYPES NOT WITH CONCRETE = GENERICS
    //     // Repo<Customer> re = new Repo<Customer>();
    //     // re.Data = new Customer{name = "anushka"};
    //     // Console.WriteLine(re.Data.name);

    //    Calculator cal = new Calculator();
    //     int result = cal.Calculate(10,20);
    //     Console.WriteLine(result);
    //     Console.WriteLine(cal.Calculate(104,20)); // working // if we do operation on a+b will not work
    //     Double result1 = cal.Calculate(23.5,56.6);
    //     Console.WriteLine(result1);
    //    Tradee t = new Tradee();
    //     t.PrintData(100);
        
          
    EquityTrad t1 = new EquityTrad
    {
        tr_id = 1,
        symboll = "AAPL",
        quant = 100,
        market = 150.5
    };

    EquityTrad t2 = new EquityTrad
    {
        tr_id = 2,
        symboll = "MSFT",
        quant = 50,
        market = null
    };

    TradeRepository<EquityTrad> repo = new TradeRepository<EquityTrad>();
    repo.Ad(t1);
    repo.Ad(t2);

    ProcessTrade(t1);
    ProcessTrade(t2);

    TradeAnalytics.Display();
}
    }