using Lesson6;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Lottery lotter = new Lottery();
        var list = lotter.Emit(20);
       
        HashSet<HashSet<int>> myList = new HashSet<HashSet<int>>();

        myList.Add(lotter.Emit(42));
        myList.Add(lotter.Emit(42));
        myList.Add(lotter.Emit(42));
        myList.Add(lotter.Emit(42));
        myList.Add(lotter.Emit(42));

        foreach (var item in myList)
        {
            
                Console.WriteLine(String.Join(",", item));
           
        }
        StatOperations op = new StatOperations();
        foreach (var key in op.MostAppeared(myList, 3).Keys)
        {
                Console.WriteLine(key + " " + op.MostAppeared(myList, 3)[key]);
        }
       
       
        Console.WriteLine(String.Join(",", op.NeverAppeared(myList)));


    }

}

