using System;
using System.Linq;
using System.Reflection;
using InterfaceLibrary;
class Program
{
    public static void Main(string[] args)
    {
        try{
        string path = @"E:\D\C#\InterfaceLibrary\bin\Debug\net10.0\InterfaceLibrary.dll";
        var a = Assembly.LoadFrom(path);

        Console.WriteLine($"Classes present are:");
        foreach(Type x in a.GetTypes().Where(t=>t.IsClass))
        {
            Console.WriteLine("\nClass name is: "+x.Name);
            MethodInfo[] meth = x.GetMethods();
            Console.WriteLine($"Methods present in class {x.Name} are:");
            foreach(var m in meth)
            {
                Console.WriteLine(m.Name);
            }
        }

        var inter = a.GetTypes().Where(t=>t.IsInterface);
        Console.WriteLine($"\nInterfaces present are:");
        foreach(var x in inter)
        {
            Console.WriteLine("\nInterface name is: "+x.Name);
            MethodInfo[] meth = x.GetMethods();
            Console.WriteLine($"Methods present in Interfaces {x.Name} are:");
            foreach(var m in meth)
            {
                Console.WriteLine(m.Name);
            }
        }}
        catch(Exception ex)
        {
            Console.WriteLine("error");
        }
    }
}