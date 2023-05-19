using Lesson6;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Lottery lotter = new Lottery();

        HashSet<HashSet<int>> myList10 = new HashSet<HashSet<int>>();
        HashSet<HashSet<int>> myList50 = new HashSet<HashSet<int>>();
        HashSet<HashSet<int>> myList100 = new HashSet<HashSet<int>>();

        StatOperations operations = new StatOperations();

        for (int i = 0; i < 10; i++)
            myList10.Add(lotter.Emit(42));
            
        for (int i = 0; i < 50; i++)
            myList50.Add(lotter.Emit(42));

        for (int i = 0; i < 100; i++)
            myList100.Add(lotter.Emit(42));

        Console.WriteLine($"Statistic for {myList10.Count} lotteries is:");
        operations.MostAppeared(myList10,3);
        operations.NeverAppeared(myList10);

        Console.WriteLine($"Statistic for {myList50.Count} lotteries is:");
        operations.MostAppeared(myList50, 5);
        operations.NeverAppeared(myList50);

        Console.WriteLine($"Statistic for {myList100.Count} lotteries is:");
        operations.MostAppeared(myList100, 10);
        operations.NeverAppeared(myList100);



    }

}

