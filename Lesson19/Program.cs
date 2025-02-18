void Count(object x)
{
    int n = (int)x;
    for (int i = 0; i < 9; i++)
    {
        Console.Write("Второй поток: ");
        Console.WriteLine(i*n);
        Thread.Sleep(1200);
    }
}
void Print(object? obj)
{
    if(obj is int n)
    {
        Console.WriteLine($"n*n = {n*n}");
    }
}

Console.Write("введите n:");
int n = int.Parse(Console.ReadLine()!);
Thread thread = new Thread(Print);
thread.Start(n);

//Thread thread = new Thread(new ParameterizedThreadStart(Count));
//thread.Start(n);
//for (int i = 0; i < 9; i++)
//{
//    Console.Write("Остновной поток: ");
//    Console.WriteLine(i * i);
//    Thread.Sleep(1000);
//}
