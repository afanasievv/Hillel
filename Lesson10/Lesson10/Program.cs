using System.Runtime.InteropServices;
using System.Threading;

class Program

{
    static void Main()
    {
        Object lockObject = new object();
        List<int> arrayOfNumbers = new List<int>();
        List<Task> tasks = new List<Task>();
        int result = 0;
        int taskSumCount = 4;
        int arrayOfNumbersCount = 100000;
        int partLenght = arrayOfNumbersCount / taskSumCount;

        for (int i = 0; i < arrayOfNumbersCount; i++)
            arrayOfNumbers.Add(new Random().Next(1, 20));


        var task5 = Task.Run(() =>
        {
            Console.WriteLine("Task 5 started");
            if (arrayOfNumbers.Count(x => x <= 0) == 0)
            {
                Console.WriteLine("There are no negative numbers in array");
                                
                return true;
            }
            else return false;

        });

        
        for (int i = 0; i < taskSumCount; i++)
        {
            int startIndex = i * partLenght;
            int endIndex = i == taskSumCount - 1 ? arrayOfNumbersCount : (i + 1) * partLenght;
            var task =  Task.Run(async () => {
                if (await task5)
                {
                    Console.WriteLine($"Task started");
                    int sum = 0;
                    for (int j = startIndex; j < endIndex; j++)
                    {
                        sum += arrayOfNumbers[j];
                    }
                    lock (lockObject)
                        result += sum;
                    Console.WriteLine($"Task result is {sum}");
                }
            });
                       
        }
        Thread.Sleep(1000);
        Console.WriteLine($"Sum = {result}");
        Console.ReadLine();

    }

}