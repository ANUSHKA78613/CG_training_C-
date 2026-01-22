namespace InterfaceLibrary;

public interface I1
{
    public void M1();
    public void M2();
  
}
public interface I2
{
    public void M3();
}
public interface I3
{
    public void M4();
}
public class A : I1,I2,I3
{
public void M1()
{
     Console.WriteLine("we r in M1");
}
public void M2()
    {
        Console.WriteLine("We r in M2");
    }
public void M3()
    {
        Console.WriteLine("We r in M3");
    }
public void M4()
    {
        Console.WriteLine("We r in M4");
    }
}
public class B : A
{
    public void Bb()
    {
        Console.WriteLine("we r in B class");
    }
}
