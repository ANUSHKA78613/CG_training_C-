using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "log.txt";
        string outputFile = "error.txt";

        if (!File.Exists(inputFile))
        {
            File.Create(inputFile).Close();
        }

        if (!File.Exists(outputFile))
        {
            File.Create(outputFile).Close();
        }

        string[] lines = File.ReadAllLines(inputFile);

        using (StreamWriter writer = new StreamWriter(outputFile, false))
        {
            foreach (string line in lines)
            {
                if (line.IndexOf("ERROR", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
