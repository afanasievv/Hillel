class Program
{
    static List<int> resultList = new List<int>();
    static List<int> lst= new List<int>();
    static void Main()
    {
        int countOfListNumbers = 100000;
        int firstQuarterBorder = 25000;
        int secondQuarterBorder = 50000;
        int thirdQuarterBorder = 75000;
        int fourthQuarterBorder = countOfListNumbers;


        for (int i = 0; i < countOfListNumbers; i++)
            lst.Add(i);

        var thread1 = new Thread(() => { CheckSquareRootIsInteger(0, firstQuarterBorder); });
        var thread2 = new Thread(() => { CheckSquareRootIsInteger(firstQuarterBorder, secondQuarterBorder); });
        var thread3 = new Thread(() => { CheckSquareRootIsInteger(secondQuarterBorder, thirdQuarterBorder); });
        var thread4 = new Thread(() => { CheckSquareRootIsInteger(thirdQuarterBorder, fourthQuarterBorder); });

        List<Thread> threads = new List<Thread>() { thread1, thread2, thread3, thread4 };
        threads.ForEach(thread => { thread.Start();});
        
        //while(threads.Any(t=>t.ThreadState != ThreadState.Stopped));
        Console.WriteLine(String.Join(",", resultList));

    }
    public static void CheckSquareRootIsInteger(int from, int to)
    {
        
        for (int i = from; i < to; i++)
        {
            if (Math.Sqrt(lst[i]) % 1 == 0)
                resultList.Add(lst[i]);
        }
    }


}

