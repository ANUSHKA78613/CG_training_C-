using System;
struct PriceSnapShot
{
    public required string symboll;
    public double Price;
    public PriceSnapShot()
    {}
}
abstract class Trad
{
    public string symboll;
    public int tr_id;
    public int quant;
    public abstract double Calcu();
    public override string ToString()
    {
        return $"ID:{tr_id}\nTrade Symbol: {symboll}\n quantity: {quant}";
    }
}

class EquityTrad : Trad
{
    public double? market{get;set;}
    
    public  override double Calcu(){
        return quant*(market ?? 0);
}
}

class TradeRepository<T> where T : Trad
{
    List<T> l = new List<T>();
    public static int count = 0;
    public void Ad(T data)
        {
            l.Add(data);
            count++;
            TradeAnalytics.c++;

            Console.WriteLine("Trade added successfully");
        }
    
}

static class TradeAnalytics 
    {
    public static int c=0;
     public static void Display()
        {
            Console.WriteLine($"Total trade: {c}");
        }   

}

static class TradeExtension
{
    public static double Brokerage(this double amount, double rate)
    {
        return amount*rate/100;
    }
    public static double GST(this double amount, double rate)
    {
        return amount*rate/100;
    }
}

