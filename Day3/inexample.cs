class Display
{
    public static void Show(in int number)
    {
        Console.WriteLine(number);
        
      //   number = number + 10;   // Not allowed
      // in =  variable is passed by reference but no modification is allowed
    }
}