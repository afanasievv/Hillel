using Lesson6;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Lottery lotter = new Lottery();
              
        HashSet<HashSet<int>> myList10 = new HashSet<HashSet<int>>();
        HashSet<HashSet<int>> myList50= new HashSet<HashSet<int>>();
        StatOperations operations = new StatOperations();
        for (int i = 0; i < 10; i++)
        myList10.Add(lotter.Emit(42));

        for (int i = 0; i < 50; i++)
            myList50.Add(lotter.Emit(42));

        var neverAppearedfor10 = operations.NeverAppeared(myList10);
        var mostAppearedfor10 = operations.MostAppeared(myList10, 3);
        var neverAppearedfor50 = operations.NeverAppeared(myList50);
        var mostAppearedfor50 =operations.MostAppeared(myList50, 5);
        
        foreach (var key in mostAppearedfor10.Keys)
        {
            Console.WriteLine(key + " " + mostAppearedfor10[key]);
        }
        Console.WriteLine(String.Join(",", neverAppearedfor10));
        
        foreach (var key in mostAppearedfor50.Keys)
        {
            Console.WriteLine(key + " " + mostAppearedfor50[key]);
        }
       Console.WriteLine(String.Join(",", neverAppearedfor50));
        

    }

}

