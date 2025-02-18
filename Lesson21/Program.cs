
//await PrintTask(); 
//await PrintAsync();
//Console.WriteLine("Основной поток");

using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;

//await PrintNameAsync("Arin");
//await PrintNameAsync("Tom");
//await PrintNameAsync("Bob");

//Account account = new Account();
//account.Added += PrintAsync;
//account.Put(500);
//await Task.Delay(2000);

//var task = PrintAsyncTask("Hello");
//Console.WriteLine("Основная программа");
//await task;

//int n1 = await SquareAsync(6);
//int n2 = await SquareAsync(7);
//Console.WriteLine($"{6}^2={n1}\n{7}^2={n2}");
//var result = await AddAsync(7, 6);
//Console.WriteLine(result);

//Первый способ
//await PrintAsyncTask("first");
//await PrintAsyncTask("second");
//await PrintAsyncTask("third");

//Второй способ
//var t1 = PrintAsyncTask("first");
//var t2 = PrintAsyncTask("second");
//var t3 = PrintAsyncTask("third");
//await t1;
//await t2;
//await t3;

//Третий
//await Task.WhenAll(t1, t2, t3);

////await Task.WhenAny(t1, t2, t3);
//Console.WriteLine("Test");

var t1 = SquareAsync(5);
var t2 = SquareAsync(6);
var t3 = SquareAsync(7);
//int[] mas = await Task.WhenAll(t1, t2, t3);
await Task.WhenAny(t1, t2, t3);
Console.WriteLine(t1.Result);
Console.WriteLine(t2.Result);
Console.WriteLine(t3.Result);
//foreach (int i in mas)
//    Console.WriteLine(i);
Console.WriteLine("Жду");

async void PrintAsync(object? obj, string mes)
{
    await Task.Delay(1000);
    Console.WriteLine(mes);
}
async Task<int> SquareAsync(int n)
{
    Task.Delay(1000);
    return n*n;
}
//async Task<int> SquareAsync(int n)
//{
//    await Task.Delay(0);
//    return n * n;
//}
ValueTask<int> AddAsync(int a, int b)
{
    return new ValueTask<int>(a + b);
}
async Task PrintAsyncTask(string mes)
{
    await Task.Delay(3000);
    Console.WriteLine(mes);
}
void Print()
{
    Thread.Sleep(3000);
    Console.WriteLine("Hello");
}
//async Task PrintAsync()
//{
//    await Task.Delay(3000);
//    Console.WriteLine("Hello Async");
//}
async Task PrintTask()
{
    Console.WriteLine("Начало метода ...");
    await Task.Run(() => Print());
    Console.WriteLine("Конец метода ...");
}
async Task PrintNameAsync(string name)
{
    await Task.Delay(3000);
    Console.WriteLine(name);
}
class Account
{
    int sum = 0;
    public event EventHandler<string>? Added;
    public void Put(int sum)
    {
        this.sum += sum;
        Added?.Invoke(this, $"На счет поступило {sum}");
    }
}