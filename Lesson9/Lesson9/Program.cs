class Program
{   static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
    static void Main()
    {
        const int sumThreadCount = 4;

        List<int> arrayOfNumbers=new List<int>();

        for (int i = 0; i < 10; i++)
            arrayOfNumbers.Add(1);//new Random().Next(1,20));

        int[]result=new int[sumThreadCount];
       
        int partLenght = arrayOfNumbers.Count / sumThreadCount;

        Thread thread = new Thread(() =>
            {
                if (arrayOfNumbers.Count(x => x <= 0) > 0)
                    Console.WriteLine("В масиві присутні від'ємні числа!");
                else autoResetEvent.Set();

            });

        thread.Start();
        thread.Join();

        for (int i = 0;i < sumThreadCount; i++)
        {
            int startIndex = i * partLenght;
            int endIndex = i==sumThreadCount-1? arrayOfNumbers.Count:(i+1)*partLenght;
            (new Thread(() => 
            {
                autoResetEvent.WaitOne();
                int sum=0;
                for(int j= startIndex; j < endIndex; j++)
                {
                    sum += arrayOfNumbers[j];
                }
                 result[i] = sum;

            })).Start();
         
        }
        int totalSum = 0;
        foreach(int i in result)
        {
            totalSum += i;
        }

        Console.WriteLine(totalSum);
       
    }
}