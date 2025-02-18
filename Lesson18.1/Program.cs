//алгоритмы синхронизации
//крические секции
//int x = 100;
//object locker = new();
//for (int i = 0; i < 6; i++)
//{
//    Thread myThread = new Thread(Print);
//    myThread.Name = $"Поток {i}";
//    myThread.Start();
//    if (x == 0) myThread.Interrupt();
//}
//Console.WriteLine(x);
//void Print()
//{
//    //x = 1;
//    lock (locker) //крические секции
//    {
//        for (int i = 0; i < 6; i++)
//        {
//            Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
//            x--;
//            Thread.Sleep(100);
//        }
//    }
//}

//мониторы
//int x = 100;
//object locker = new();
//for (int i = 0; i < 6; i++)
//{
//    Thread myThread = new Thread(Print);
//    myThread.Name = $"Поток {i}";
//    myThread.Start();
//    if (x == 0) myThread.Interrupt();
//}
//void Print()
//{
//    bool acquireLock = false;
//    try
//    {
//        //x = 1;
//        Monitor.Enter(locker, ref acquireLock);
//        for (int i = 0; i < 6; i++)
//        {
//            Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
//            x--;
//            Thread.Sleep(100);
//        }
//    }
//    finally
//    {
//        if (acquireLock)
//        {
//            Monitor.Exit(locker);
//        }
//    }
//}

//класс AutoResetEvent
//int x = 100;
//AutoResetEvent waitHandler = new AutoResetEvent(true);
//for (int i = 0; i < 6; i++)
//{
//    Thread myThread = new Thread(Print);
//    myThread.Name = $"Поток {i}";
//    myThread.Start();
//    if (x == 0) myThread.Interrupt();
//}
//void Print()
//{
//    waitHandler.WaitOne();
//        for (int i = 0; i < 6; i++)
//        {
//            Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
//            x--;
//            Thread.Sleep(100);
//        }
//        waitHandler.Set();
//}

//мьютекс
//int x = 100;
//Mutex mutexObj = new();
//for (int i = 0; i < 6; i++)
//{
//    Thread myThread = new Thread(Print);
//    myThread.Name = $"Поток {i}";
//    myThread.Start();
//    if (x == 0) myThread.Interrupt();
//}
//void Print()
//{
//    mutexObj.WaitOne();
//        for (int i = 0; i < 6; i++)
//        {
//            Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
//            x--;
//            Thread.Sleep(100);
//        }
//    mutexObj.ReleaseMutex();
//}

//симофор
//for (int i = 0; i < 6; i++)
//{
//    Reader reader = new Reader(i);
//}
//class Reader
//{
//    static Semaphore sem = new Semaphore(3, 3);
//    Thread myThread;
//    int count = 3;
//    public Reader(int i)
//    {
//        myThread = new Thread(Read);
//        myThread.Name = $"Читатель: {i}";
//        myThread.Start();
//    }
//    public void Read()
//    {
//        while (count > 0)
//        {
//            sem.WaitOne();
//            Console.WriteLine($"Входит {Thread.CurrentThread.Name}");
//            Console.WriteLine($"{Thread.CurrentThread.Name} читает.");
//            Thread.Sleep(1000);
//            Console.WriteLine($"{Thread.CurrentThread.Name} уходит.");
//            sem.Release();
//            count--;
//            Thread.Sleep(1000);
//        }
//    }
//}


//// Создаем новый поток и передаем ему метод, который он будет выполнять.
//Thread thread = new Thread(CountTo100);
//// Запускаем второстепенный поток.
//thread.Start();

//// Основной поток будет выполняться параллельно с созданным потоком.
//for (int i = 0; i < 20; i++)
//{
//    Console.SetCursorPosition(30, i);
//    Console.WriteLine($"Основной поток: {i}");
//    Thread.Sleep(650); // Приостанавливаем основной поток на некоторое время.
//}

//// Ожидаем завершения созданного потока.
//thread.Join();
//Console.WriteLine("Оба потока завершили работу.");

//static void CountTo100()
//{
//    for (int i = 0; i < 20; i++)
//    {
//        Thread.Sleep(600); // Приостанавливаем поток на некоторое время.
//        Console.WriteLine($"Второстепенный поток: {i}");
//    }
//}

//Thread highPriorityThread = new Thread(DoWork);
//Thread lowPriorityThread = new Thread(DoWork);
//// Устанавливаем название потока для highPriorityThread
//highPriorityThread.Name = "Высокоприоритетный поток";
//// Устанавливаем название потока для lowPriorityThread
//lowPriorityThread.Name = "Низкоприоритетный поток";
//// Устанавливаем высокий приоритет для highPriorityThread
//highPriorityThread.Priority = ThreadPriority.Highest;
//// Устанавливаем низкий приоритет для lowPriorityThread
//lowPriorityThread.Priority = ThreadPriority.Lowest;
//highPriorityThread.Start();
//lowPriorityThread.Start();
//highPriorityThread.Join();
//lowPriorityThread.Join();
//Console.WriteLine("Оба потока завершили работу");
//static void DoWork()
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.WriteLine(Thread.CurrentThread.Name + ": Текущий шаг " + i );
//    }
//}