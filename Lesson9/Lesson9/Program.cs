using System.Runtime.InteropServices;
using System.Threading;

class Program

{   
    static void Main()
    {
        Object lockObject = new object();
        CountdownEvent countdown = new CountdownEvent(1);
        List<int> arrayOfNumbers = new List<int>();
        List<Thread> threads = new List<Thread>();
        int result = 0;
        int threadSumCount = 4;        
        int arrayOfNumbersCount = 100000;
        int partLenght = arrayOfNumbersCount / threadSumCount; 
       
        for (int i = 0; i < arrayOfNumbersCount; i++)
            arrayOfNumbers.Add(new Random().Next(1, 20));

        for (int i = 0;i < threadSumCount; i++)
        {
            int startIndex = i * partLenght;
            int endIndex = i==threadSumCount-1? arrayOfNumbersCount:(i+1)*partLenght;
            var thread = new Thread(id => {
                countdown.Wait();
                Console.WriteLine($"Thread {id} started");
                int sum = 0;
                for (int j = startIndex; j < endIndex; j++)
                {
                    sum += arrayOfNumbers[j];
                }
                lock (lockObject)
                    result += sum;
                Console.WriteLine($"Thread {id} result is {sum}");
                
            });
            threads.Add(thread);
            thread.Start(i+1);
        }

        Thread thread5 = new Thread(() =>
        {
            Console.WriteLine("Thread 5 started");
            if (arrayOfNumbers.Count(x => x <= 0) == 0)
            {
                Console.WriteLine("There are no negative numbers in array");
                countdown.Signal();
            }

        });
        thread5.Start();
        threads.Add(thread5);

        foreach (Thread thread in threads)
            thread.Join();

        Console.WriteLine($"Sum = {result}");
        Console.ReadLine();
       
    }
    
}