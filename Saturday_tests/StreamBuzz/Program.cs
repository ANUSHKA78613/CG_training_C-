using System;
using System.Collections.Generic;
class Program
{
      public void RegisterCreator(CreatorStats record)
    {
    EngagementBoard.Add(record);
    }
    public Dictionary<string,int>GetTopPostCounts(List<CreatorStats>records,double likeThreshold)
    {
        Dictionary<string,int> result = new Dictionary<string, int>();
        foreach(CreatorStats cr in records)
    {
        int c =0;
        foreach(double likes in cr.WeeklyLikes)
        {
            if(likes >= likeThreshold)
            {
                c++;
            }
        }
            if(c>0)
            if (!result.ContainsKey(cr.CreatorName))
{
    result.Add(cr.CreatorName, c);
}
        }
        return result;
    }
    
    public double CalculateAverageLikes()
    {
        double total=0;
        int c=0;
       foreach(CreatorStats cr in EngagementBoard)
    {
        foreach(double likes in cr.WeeklyLikes)
        {
            total += likes;
            c++;
        }
    }
    if(c ==0) return 0;
    return total/c;
    }
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
    public static void Main()
    {
        Program p = new Program();
        int choice;
        do
        {
            Console.WriteLine("/n1.Register Creator");
            Console.WriteLine("/n2.Show Top Posts");
            Console.WriteLine("/n3.Calculate Average Likes");
            Console.WriteLine("/n4.Exit");
            Console.WriteLine("/nEnter Your Choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:  CreatorStats cr = new CreatorStats();
                Console.WriteLine("\nEnter Creator Name: ");
                        cr.CreatorName = Console.ReadLine();
                       Console.WriteLine("\nEnter Weekly likes(Week 1 to 4) ");
                      cr.WeeklyLikes = new double[4];
                      for(int i = 0; i < 4; i++)
            {
                cr.WeeklyLikes[i] = Convert.ToDouble(Console.ReadLine());
                p.RegisterCreator(cr);
            }
                       
                       Console.WriteLine("\nCreator registered successfully");
                break;
                case 2: 
                Console.WriteLine("\nenter threshold likes:");
                double threshold = Convert.ToDouble(Console.ReadLine());
                Dictionary<string,int>top = p.GetTopPostCounts(EngagementBoard,threshold);
                if(top.Count == 0)
                {
                    Console.WriteLine("no top performer");
                }
                else
                {
                    foreach(var item in top){
                        Console.WriteLine(item.Key+"-"+item.Value);
                    }
                }
                Console.WriteLine();
                break;
                case 3: double avg = p.CalculateAverageLikes();
                Console.WriteLine("Overall avg weekly likes: "+avg);
                Console.WriteLine();
                break;
                case 4: Console.WriteLine("logging off");
                break;
            }

        }
        while(choice!=4);
    }

}