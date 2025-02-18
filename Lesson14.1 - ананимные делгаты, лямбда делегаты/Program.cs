////Action
//void DoOperation(int a, int b, Action<int,int> op) => op(a,b);
//void Add(int a, int b) => Console.WriteLine($"{a}+{b}={a+b}");
//void Sub(int a, int b) => Console.WriteLine($"{a}-{b}={a - b}");
//int DoOperationInt(int n, Func<int, int> op) => op(n);
////Func
//int DoulbeNmber(int n) => 2 * n;
//int SquareNumber(int n) => n * n;
////Predicate
//Predicate<int> isPositive = (int x) => x > 0;
////Главная Программа
//DoOperation(19, 4, Add);
//DoOperation(19, 4, Sub);
//Console.WriteLine(DoOperationInt(5, DoulbeNmber));
//Console.WriteLine(DoOperationInt(5, SquareNumber));
//Console.WriteLine(isPositive(8));
//Console.WriteLine(isPositive(-7));

//Анонимные методы
//MessageHandler hendler = delegate (string mes)
//{
//    Console.WriteLine(mes);
//};
//void ShowMessage(string mes, MessageHandler handler)
//{
//    hendler(mes);
//}
//Operation operation = delegate (int x, int y)
//{
//    return x + y;
//};
//hendler("Helloy World!!!");
//ShowMessage("helloy", delegate (string name)
//{
//    Console.WriteLine(name);
//});
//int res3 = operation(4, 80);
//Console.WriteLine(res3);
//delegate void MessageHandler(string mes);
//delegate int Operation(int x, int y);

//Лямбда выражения
//Massage hello = () => Console.WriteLine("Hello!!!");
//hello();
//var hel=() => Console.WriteLine("hel");
//hel();
//var welcom = (string mes = "My message") => Console.WriteLine(mes);
//welcom();
//var sum=(int x,int y) => x + y;
//Operation sub=(x,y) => x - y;
//Console.WriteLine(sum(4,8));
//Console.WriteLine(sub(4,8));
//var div=(int x, int y) =>
//    {
//        if (y != 0) return x / y;
//        return 0;
//    };
//Console.WriteLine(div(6,0));
//var mymes = () => Console.WriteLine("C# hello");
//var mypres = () => Console.WriteLine("My language");
//mymes += mypres;
//mymes();
//mymes -= mypres;
//mymes();
//delegate void Massage();
//delegate int Operation(int x, int y);



//------------------------------
int Sum(int[] mas, IsEqual func)
{
    int s = 0;
    foreach (int item in mas)
        s += item;
    return s;
}
int Mult(int[] mas, Predicate<int> func)
{
    int s = 1;
    foreach (int item in mas)
        s *= item;
    return s;
}

int[] integers = new int[10];
Random random = new Random();
for (int i = 0; i < integers.Length; i++)
{
    integers[i] = random.Next(1,21);
    Console.WriteLine(integers[i]+" ");
}
Console.WriteLine();
int SumEven = Sum(integers, x => x % 2 == 0);
int SumPos=Sum(integers, x=>x>0);
Console.WriteLine(SumEven);
Console.WriteLine(SumPos);
Console.WriteLine(Mult(integers, x=>x%2!=0));
Console.WriteLine(Mult(integers, x => x<0));


delegate void MessageHandler(string mes);
delegate int Operation(int x, int y);
delegate void Massage();
delegate bool IsEqual(int x);