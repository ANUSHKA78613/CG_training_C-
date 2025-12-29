using System;
using System.Collections;
using System.Collections.Generic;

class Assign
{
    public static void Price()
    {
       
        Console.Write("Enter the number of products: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] prices = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Enter price for product {i}: ");
                int value = Convert.ToInt32(Console.ReadLine());
                if (value > 0)
                {
                    prices[i] = value;
                    break;
                }
                Console.WriteLine("Only positive prices allowed.");
            }
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
            sum += prices[i];

        double avg = (double)sum / n;
        Console.WriteLine("Average price: " + avg);

        Array.Sort(prices);
        for (int i = 0; i < n; i++)
            if (prices[i] < avg)
                prices[i] = 0;

        int oldSize = prices.Length;
        Array.Resize(ref prices, oldSize + 5);
        for (int i = oldSize; i < prices.Length; i++)
            prices[i] = (int)avg;

        Console.WriteLine("\nFinal Array:");
        for (int i = 0; i < prices.Length; i++)
            Console.WriteLine($"Index {i} : {prices[i]}");

      
        Console.WriteLine("\nEnter no of branches: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of months: ");
        int col = Convert.ToInt32(Console.ReadLine());

        int[,] a = new int[row, col];

        for (int i = 0; i < row; i++)
            for (int j = 0; j < col; j++)
            {
                Console.Write($"Branch {i}, Month {j}: ");
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }

        int max = int.MinValue;
        for (int i = 0; i < row; i++)
        {
            int branchSum = 0;
            for (int j = 0; j < col; j++)
            {
                branchSum += a[i, j];
                if (a[i, j] > max)
                    max = a[i, j];
            }
            Console.WriteLine($"Total sales of Branch {i}: {branchSum}");
        }
        Console.WriteLine("Highest Monthly Sale: " + max);

       
        int[][] jagged = new int[row][];

        for (int i = 0; i < row; i++)
        {
            List<int> temp = new List<int>();
            for (int j = 0; j < col; j++)
                if (a[i, j] >= avg)
                    temp.Add(a[i, j]);

            jagged[i] = temp.ToArray();
        }

        for (int i = 0; i < jagged.Length; i++)
        {
            Console.Write($"Branch {i}: ");
            if (jagged[i].Length == 0)
                Console.WriteLine("No qualifying sales");
            else
            {
                for (int j = 0; j < jagged[i].Length; j++)
                    Console.Write(jagged[i][j] + " ");
                Console.WriteLine();
            }
        }

        
        Console.Write("\nEnter number of customer transactions: ");
        int txnCount = int.Parse(Console.ReadLine());

        List<int> customers = new List<int>();
        for (int i = 0; i < txnCount; i++)
            customers.Add(int.Parse(Console.ReadLine()));

        HashSet<int> uniqueCustomers = new HashSet<int>(customers);
        Console.WriteLine("Duplicates Removed: " +
            (customers.Count - uniqueCustomers.Count));

      
        Console.Write("\nEnter number of financial transactions: ");
        int finCount = int.Parse(Console.ReadLine());

        Dictionary<int, double> transactions = new Dictionary<int, double>();
        for (int i = 0; i < finCount; i++)
        {
            int id = int.Parse(Console.ReadLine());
            if (!transactions.ContainsKey(id))
                transactions.Add(id, double.Parse(Console.ReadLine()));
        }

        SortedList<int, double> sorted = new SortedList<int, double>();
        foreach (var t in transactions)
            if (t.Value >= avg)
                sorted.Add(t.Key, t.Value);

       
        Console.Write("\nEnter number of operations: ");
        int ops = int.Parse(Console.ReadLine());

        Queue<string> q = new Queue<string>();
        Stack<string> s = new Stack<string>();

        for (int i = 0; i < ops; i++)
        {
            string op = Console.ReadLine();
            q.Enqueue(op);
            s.Push(op);
        }

        while (q.Count > 0)
            Console.WriteLine(q.Dequeue());

        for (int i = 0; i < 2 && s.Count > 0; i++)
            Console.WriteLine("Undo: " + s.Pop());

       
        Console.Write("\nEnter number of users: ");
        int users = int.Parse(Console.ReadLine());

        Hashtable table = new Hashtable();
        ArrayList list = new ArrayList();

        for (int i = 0; i < users; i++)
        {
            string u = Console.ReadLine();
            string r = Console.ReadLine();
            table.Add(u, r);
            list.Add(u);
            list.Add(r);
            list.Add(i);
        }
    }
}
