using System;
using System.Collections.Generic;
using System.Collections;
class Dynamic
{
    public static void A()
    {
        // ArrayList arr = new ArrayList(); // non generic
        // arr.Add(3);
        // arr.Add(32);
        // arr.Add(322);
        // List<int> n = new List<int>(); // generic
        // n.Add(33);
        // n.Add(3223);
        // n.Add(331);
        // foreach(int x in arr)
        // {
        //     Console.Write(x+" ");
        // }
        // foreach(int x1 in n)
        // {
        //     Console.WriteLine(x1+" ");
        // }
        // Hashtable ht = new Hashtable();
        // ht.Add(1,"Anu");
        // ht.Add(2,"Vishu");
        // foreach(var x1 in ht.Values)
        // {
        //     Console.WriteLine(x1);
        // }
        // Queue queue = new Queue();
        // queue.Enqueue(10);
        // queue.Enqueue(20);
        // Console.WriteLine(queue.Dequeue());
        Dictionary<int,string> users = new Dictionary<int,string>();
        users.Add(1,"Anu");
        users.Add(11,"Vishu");
        foreach(string x in users.Values)
        {
            Console.WriteLine(x);
        }
        foreach(KeyValuePair<int,string> emp in users)
        {
            Console.WriteLine(emp.Key+"-"+emp.Value);
        }
        // HashSet<int> set = new HashSet<int>(); // stores unique element
        // set.Add(1);
        // set.Add(12);
        // foreach(int x in set){
        //     Console.WriteLine(x);
        // }
        // SortedList<string,string> l = new SortedList<string, string>();
        // l.Add("b","B");
        // l.Add("a","A");
        // foreach(var x in l)
        // {
            
        //     Console.WriteLine(x.Key+":"+x.Value);
        // }


    }
}