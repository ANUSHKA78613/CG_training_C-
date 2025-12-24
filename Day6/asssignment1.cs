using System;
using System.Collections.Generic;
class Tradee
{
    public int TradeId { get; set; }
    public string Symbol { get; set; }

    public void PrintData<T>(T data)
    {
        Console.WriteLine(data);
    }
}




