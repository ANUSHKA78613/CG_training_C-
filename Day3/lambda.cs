using System;
class Lam
{
   public static  void Example()
{
    int Square(int x)
    {
        return x * x;
    }
    Func<int, int> squareLambda = x => x * x; // x is input parameter , => goes to

    Console.WriteLine(Square(4));
    Console.WriteLine(squareLambda(4));
}
}