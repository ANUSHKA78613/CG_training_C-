using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
class Program
{
    public static void Main()
    {
       // F.SS();
     //  User user = new User{Id = 1, Name = "Alice"};
    //    using(StreamWriter writer = new StreamWriter("user.txt"))
    //     {
    //         writer.WriteLine(user.Id);
    //         writer.WriteLine(user.Name);
    //         user.Id = 2;
    //         user.Name = "Bob";
    //         writer.WriteLine(user.Id);
    //         writer.WriteLine(user.Name);
    //     }
    //     Console.WriteLine("data added successfully");
    // using(StreamReader reader = new StreamReader("user.txt"))
    //     {
    //         user.Id = int.Parse(reader.ReadLine());
    //         user.Name = reader.ReadLine();
    //     }
    //     Console.WriteLine($"User loaded: {user.Id}  {user.Name}");

    // using(BinaryWriter writer = new BinaryWriter(File.Open("user.bin", FileMode.Create)))
    //     {
    //         writer.Write(user.Id);
    //         writer.Write(user.Name);
    //     }
    //     Console.Write("binary user data saved");

    // using (BinaryReader reader = new BinaryReader(File.Open("user.bin", FileMode.Open)))
    //     {
    //         Console.WriteLine(reader.ReadInt32());
    //        Console.WriteLine(reader.ReadString()); 
    //     }

    // FileInfo file = new FileInfo("sample.txt");
        // if (!file.Exists)
        // {
        //     using(StreamWriter writer = file.CreateText())
        //     {
        //       writer.WriteLine("hello fileinfo class");  
        //     }
        // }
        // Console.WriteLine("file name: "+file.Name);
        // Console.WriteLine("file size: "+file.Length+" bytes");
        // Console.WriteLine("Created on: "+file.CreationTime);

    // Directory.CreateDirectory("logs");
    // if(Directory.Exists("logs")){
    //     Console.WriteLine("logs directory created");
    // }

    // DirectoryInfo dir = new DirectoryInfo("Logs");
    // if(!dir.Exists){
    //     dir.Create();
    // }
    // Console.WriteLine("Directory name:" + dir.Name);
    // Console.WriteLine("created on:" + dir.CreationTime);
    // Console.WriteLine("Full PAth:" + dir.FullName);
    //------------------------------serialization------------------------

    // User user = new User{Id = 1,Name = "bob"};
    // string json = JsonSerializer.Serialize(user);
    // File.WriteAllText("user.json",json);
    // Console.WriteLine("json serializaed successfully");
// ----------------------DEserialization---------------
//  string json = File.ReadAllText("user.json");
//  User user = JsonSerializer.Deserialize<User>(json);
//  Console.WriteLine($"User loaded: {user.Id} {user.Name}");
    
    // User user = new User {Id = 1,Name = "alice"};
    // XmlSerializer serializer = new XmlSerializer(typeof(User));
    // using (FileStream fs = new FileStream("user.xml",FileMode.Create))
    // {
    //     serializer.Serialize(fs,user);
    // }
    // Console.WriteLine("Xml Serializing");
    // Console.WriteLine(typeof(User));
   
    }
}
