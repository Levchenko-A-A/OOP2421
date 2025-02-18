using Lesson9;

//string? email = "rest@mail.-ru";
//if (email.IsValidEmaillAddress()) 
//    Console.WriteLine("Это email");
//else Console.WriteLine("Не email");

//Console.Write("Введите строку:");
//string str=Console.ReadLine()!;
//Console.Write("Введите символ:");
//char ch=char.Parse(Console.ReadLine()!);
//Console.WriteLine(str.CountChar(ch));


//Message mes;
//mes = Hello;
//mes();
//mes = MyMessage;
//mes.Invoke();
//mes();
////Message message1 = new Message(Welcome.Print);
//Message message1 = Welcome.Print;
//message1();
////Message message2 = new Message(Hello().Display);
//Message message2 = new Hello().Display;

//MyClass.Main();

//void Hello()
//{
//    Console.WriteLine("Hello, world");
//}
//void MyMessage()
//{
//    Console.WriteLine($"{2+3}={5}");
//}
//delegate void Message();

//class Welcome
//{
//    public static void Print() => Console.WriteLine("Welcom");
//}
//class Hello
//{
//    public void Display()=> Console.WriteLine("Привет");
//}

//Operation operation = Add;
//Console.WriteLine(operation(4,7));
//operation = Sub;
//operation += Add;
//operation += Mult;
//operation += Div;

//Delegate[] delegates = operation.GetInvocationList();
//foreach (Operation d in delegates)
//{
//    Console.WriteLine(d(4,6));
//}
//operation -= Sub;
//foreach (Operation d in delegates)
//{
//    Console.WriteLine(d(4, 6));
//}

//Console.WriteLine(operation(4, 6));
//Message mes = Hello;
//mes += World;
//mes();
Operation operation = null;
Console.Write("Введите первую переменную:");
int x=int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую переменную:");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите операцию:");
char op = char.Parse(Console.ReadLine()!);
switch(op)
{
    case '+':operation = Add; break;
    case '-':operation = Sub; break;
    case '*':operation = Mult; break;
    case '/':operation = Div; break;
    default: Console.WriteLine("Такой операции нет"); break;
}
if (operation != null) Console.WriteLine($"Result={operation(x,y)}");
int Add(int x, int y) => x + y;
int Sub(int x, int y) => x - y;
int Mult(int x, int y) => x * y;
int Div(int x, int y) => x / y;

//void Hello() => Console.WriteLine("Hello, ");
//void World() => Console.WriteLine("World");

delegate void Message();
delegate int Operation(int x, int y);