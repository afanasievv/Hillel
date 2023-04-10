using Lesson5;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


public  class Program
{
   
    
    
    public static void Main()
    {

        double[] numbers = { 1, 2, 3, 4, 5,25,26,27 };
        ArrayHandler array = new ArrayHandler(numbers);
        array.IntValueHandler += array.On_IntableValue;




        var ch= array.SquareRoots(x => x >= 5);
       // array.Square(x => x % 1 == 0
       //array.Square(x => x > 5);
       //array.Square(x => x % 1 == 0);

        foreach(var x in ch)
            Console.WriteLine(x);

    }
    
}


