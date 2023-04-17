using System.Threading;


class Program
{
    static int evenNumber;
    static int oddNumber;
    static Object evenLockObject = new Object();
    static Object oddLockObject = new Object();

    static void Main()
    {
        Thread thread1 = new Thread(() => { RandomNumberGenerete(); });
        Thread thread2 = new Thread(() => { RandomNumberGenerete(); });
        Thread thread3 = new Thread(() => { RandomNumberGenerete(); });
        Thread thread4 = new Thread(() => { RandomNumberGenerete(); });
        Thread thread5 = new Thread(() => { RandomNumberGenerete(); });
        Thread thread6 = new Thread(() => { RandomNumberGenerete(); });
        Thread thread7 = new Thread(() => { RandomNumberGenerete(); });
        Thread thread8 = new Thread(() => { RandomNumberGenerete(); });
        Thread thread9 = new Thread(() => { RandomNumberGenerete(); });
        Thread thread10 = new Thread(() => { RandomNumberGenerete(); });

        List<Thread> threads = new List<Thread>(){ thread1, thread2, thread3, thread4, thread5,
                                                   thread6, thread7, thread8, thread9, thread10, };
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