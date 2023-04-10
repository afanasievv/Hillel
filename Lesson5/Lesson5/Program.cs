using Lesson5;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


public  class Program
{
   
    
    
    public static void Main()
    {

        double[] numbers = { 1, 2.5, 3, 4, 5,25,26,27 };
        ArrayHandler array = new ArrayHandler(numbers);
       
        //array.IntValueHandler += On_IntableValue;

        var test= array.SquareRoots(x => x >= 5);
       
        foreach(var x in test)
            Console.WriteLine(x);

        var test1 = array.SquareRoots(x => x %1==0);

        foreach (var x in test1)
            Console.WriteLine(x);
    }
    public static void On_IntableValue(object sender, IntegerNumberEventArg e)
    {
        Console.WriteLine($"{e.Number} Значення ціле");
    }
}


