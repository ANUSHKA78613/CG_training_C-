using System;
interface IPrintable
{
    void Print();
   // void Scan();
   const int c = 0;
}

class Report : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing report");
    }
}