using System.Runtime.InteropServices;
using System.Threading;

class Program

{
    static void Main()
    {
        Object lockObject = new object();
        //ManualResetEvent manualResetEvent = new ManualResetEvent(false);
        List<int> arrayOfNumbers = new List<int>();
        List<Task> threads = new List<Task>();
        int result = 0;
        int threadSumCount = 4;
        int arrayOfNumbersCount = 100000;
        int partLenght = arrayOfNumbersCount / threadSumCount;

        for (int i = 0; i < arrayOfNumbersCount; i++)
            arrayOfNumbers.Add(new Random().Next(1, 20));

        for (int i = 0; i < threadSumCount; i++)
        {
            int startIndex = i * partLenght;
            int endIndex = i == threadSumCount - 1 ? arrayOfNumbersCount : (i + 1) * partLenght;
            var task = new Task(async () => {
                if (await Method())
                {
                    Console.WriteLine($"Thread started");
                    int sum = 0;
                    for (int j = startIndex; j < endIndex; j++)
                    {
                        sum += arrayOfNumbers[j];
                    }
                    lock (lockObject)
                        result += sum;
                    Console.WriteLine($"Thread result is {sum}");
                }
            });
           threads.Add(task);
            //task.Start();
        }

        async  Task<bool> Method()
        {
             await Task<bool>.Run(() =>
            {
                Console.WriteLine("Thread 5 started");
                if (arrayOfNumbers.Count(x => x <= 0) == 0)
                {
                    Console.WriteLine("There are no negative numbers in array");

                    // manualResetEvent.Set();
                    return true;
                }
                else return true;


            });
            return true;
        }
        
        //thread5.Start();
        //threads.Add(thread5);

        //foreach (Thread thread in threads)
        //    thread.Join();

        Console.WriteLine($"Sum = {result}");
        Console.ReadLine();

    }

}