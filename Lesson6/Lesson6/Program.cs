using Lesson6;
using System.Collections;

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
       
        StatOperations op= new StatOperations();
        
        Console.WriteLine(String.Join(",", op.MostAppeared(myList, 50)));
       Console.WriteLine(String.Join(",", op.NeverAppeared(myList, 50)));

    }

}

