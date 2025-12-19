using System;
class Enemy
{
    public static void killed()
    {
        Console.WriteLine("GAME BEGINS");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Player Killed Enemy {i}");
            if( i == 4)
            {
                Console.WriteLine($"Player 4 is invisible Skipping Enemy {i}");
                continue;
                
            }
        }
        Console.WriteLine("GAME END");
    }
}