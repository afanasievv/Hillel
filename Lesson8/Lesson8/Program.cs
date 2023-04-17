using System.Threading;


class Program
{
    static int evenNumber;
    static int oddNumber;
    static Object evenLockObject = new Object();
    static Object oddLockObject = new Object();

    static void Main()

    {
        int threadCount = 10;
        List<Thread> threads = new List<Thread>();

        for(int i=0; i<threadCount; i++) 
        {
            threads.Add(new Thread(() => { RandomNumberGenerete(); }));
        }
                
      
        threads.ForEach(t => { t.Start(); });
        threads.ForEach(t => { t.Join(); });

        Console.WriteLine($"Згенеровано: {evenNumber} парних i {oddNumber} непарних чисел!");
    }
    public static void RandomNumberGenerete()
    {   
        Random random = new Random();
        int randomNumber = random.Next(1, 100);
        for (int i = 0; i < 100; i++)
        {
            if (randomNumber % 2 == 0)
            {
                lock (evenLockObject)
                    evenNumber++; 
            }
            else
            {
                lock (oddLockObject)
                    oddNumber++;
            }
           
        }
    }
}