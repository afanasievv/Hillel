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

        myList.Add(lotter.Emit(50));
        myList.Add(lotter.Emit(50));
        myList.Add(lotter.Emit(50));
        myList.Add(lotter.Emit(50));
        myList.Add(lotter.Emit(50));

        StatOperations op = new StatOperations();
        foreach (var key in op.MostAppeared(myList, 50).Keys)
        {
           
                Console.WriteLine(key + " " + op.MostAppeared(myList, 50)[key]);
        }
       
       // Console.WriteLine(value);
        //Console.WriteLine(String.Join(",", op.NeverAppeared(myList, 50)));


    }

}

