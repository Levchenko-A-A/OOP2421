//Task task1 = new Task(() => Console.WriteLine("Hello task1!"));
//task1.Start();

//Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Hello Task2!!"));

//Task task3 = Task.Run(() => Console.WriteLine("Hello Task3!!!"));

//task1.Wait();
//task2.Wait();
//task3.Wait();
//-------------------------------------------------------------------
//Console.WriteLine("Main store");
//Task task = new Task(() =>
//{
//    Console.WriteLine("Task start");
//    Thread.Sleep(100);
//    Console.WriteLine("Task end");
//});
////task.Start();
//task.RunSynchronously();
//Console.WriteLine("Main Ends");
////task.Wait();
/////----------------------------------------------------------------

//Task task1 = new Task(() =>
//{
//    Console.WriteLine($"Task {Task.CurrentId} starts");
//    Thread.Sleep(1000);
//    Console.WriteLine($"Task {Task.CurrentId} end");
//});
//task1.Start();
//Console.WriteLine($"task id: {task1.Id}");
//Console.WriteLine($"task id: {task1.IsCompleted}");
//Console.WriteLine($"task id: {task1.Status}");
//task1.Wait();

//-------------------------------------------
//Вложенные задачи

//var outer = Task.Factory.StartNew(() =>
//{
//    Console.WriteLine("Outer task stating...");
//    var inner = Task.Factory.StartNew(() =>
//    {
//        Console.WriteLine("Inner task stating...");
//        Thread.Sleep(1000);
//        Console.WriteLine("Inner task finished.");
//    }, TaskCreationOptions.AttachedToParent);
//});
//outer.Wait();
//Console.WriteLine("Outer task end");

//Массив здач----------------------------------------

//Task[] tasks = new Task[3]
//{
//    new Task(()=>Console.WriteLine("Task1")),
//    new Task(()=>Console.WriteLine("Task2")),
//    new Task(()=>Console.WriteLine("Task3"))
//};
//foreach (var task in tasks) task.Start();
//Task.WaitAll(tasks);

//Task[] task = new Task[3];
//int j = 1;
//for  (int i = 0; i < task.Length; i++)
//{
//    //Console.WriteLine(i);
//    task[i] = Task.Factory.StartNew(() =>
//    {
//        Thread.Sleep(1000);
//        Console.WriteLine($"Task + {j++}");
//    });
//}
//Task.WaitAll(task);
//Console.WriteLine("Завершение метода Main");

//Возвращение результатов из задач
//int Sum(int a, int b) => a + b;
//long Fact(int n)
//{
//    long f = 1;
//    for (int i = 1; i < n; i++) f *= i;
//    return f;

//}
//Random random = new Random();
//int n1 = 4, n2 = 10;
//Task<int> sumTask = new Task<int>(()=>Sum(n1, n2));
//sumTask.Start();
//Console.WriteLine($"{n1}+{n2}={sumTask.Result}");
//Task<long>[] task = new Task<long>[5];
//for(int i =0; i<task.Length;i++)
//{
//    task[i] = new Task<long>(
//    () => Fact(random.Next(10,20)));
//    task[i].Start();
//}
//for (int i = 0; i < task.Length; i++)
//    Console.WriteLine(task[i].Result);

//Task<long> sumTask2 = new Task<long>(() => Fact(10));
//sumTask2.Start();
//Console.WriteLine(sumTask2.Result);

//Генератор чисел
//Random random = new Random();
//Task<long>[] task = new Task<long>[5];
//for (int i = 0; i < task.Length; i++)
//{
//    task[i] = new Task<long>(()=> random.Next(100, 10000));
//    task[i].Start();
//}    
//for (int i = 0; i < task.Length; i++)
//    Console.WriteLine(task[i].Result);

//Задачи продолжения
//int Sum(int a, int b) => a + b;
//long Fact(int n)
//{
//    long f = 1;
//    for (int i = 1; i < n; i++) f *= i;
//    return f;
//}

//void PrintTask(Task t)
//{
//    Console.WriteLine($"Id задачи: {Task.CurrentId}");
//    Console.WriteLine($"Id предыдущая задача: {t.Id}");
//    Thread.Sleep( 1000 );
//}
//Task task1 = new Task(() => 
//{
//    Console.WriteLine($"Id задачи: {Task.CurrentId}");
//});
//Task task2 = task1.ContinueWith(PrintTask);
//task1.Start();
//task2.Wait();
//-------------------------------------------------------------
//int Sum(int a, int b) => a + b;
//void PrintResult(int sum) => Console.WriteLine($"Sum: {sum}");
//Task<int> sumTask = new Task<int>(() => Sum(4, 5));
//Task printTask = sumTask.ContinueWith(t => PrintResult(t.Result));
//sumTask.Start();
//printTask.Wait();

//Parallel.Invoke
//Parallel.Invoke(Print,
//    () =>
//    {
//        Console.WriteLine($"Выполняется задача {Task.CurrentId}");
//        Thread.Sleep(3000);
//    },
//    () => Square(10));
//void Print()
//{
//    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
//    Thread.Sleep(3000);
//}
//void Square(int n)
//{
//    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
//    Thread.Sleep(3000);
//    Console.WriteLine($"Результат: {n*n}");
//}

////Parallel.For
////Parallel.For(1, 5, Square);

////Parallel.ForEach
//ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 5, 8, 3 }, Square);

//Ввыход---------------------------------------------

//void Square(int n, ParallelLoopState pls)
//{
//    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
//    Thread.Sleep(3000);
//    Console.WriteLine($"Результат: {n * n}");

//}

////Parallel.For
////Parallel.For(1, 5, Square);

////Parallel.ForEach
//ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 5, 8, 3 }, Square);
//if (!result.IsCompleted) Console.WriteLine(result.LowestBreakIteration);
