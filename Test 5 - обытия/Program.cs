using System.Diagnostics.CodeAnalysis;

void DisplayRedMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
}

Account account = new Account(100);
account.Notify1 += DisplayMessage;
account.Notify2 += DisplayRedMessage;
account.Put(20);
account.Take(70);
account.Take(180);
account.Notify2 -= DisplayRedMessage;
account.Notify2 += DisplayMessage;
account.Put(1000);

Account acc = new Account(100);
acc.Notify1 += new Account.AccountHandler(DisplayMessage);
acc.Notify2 += new Account.AccountHandler(DisplayRedMessage);
acc.Put(1000);

Account acc1 = new Account(100);
acc1.Notify1 += delegate (string mes)
{
    Console.WriteLine(mes);
};
acc1.Notify2 += delegate (string mes)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(mes);
    Console.ResetColor();
};
acc1.Put(1800);

Account account1 = new Account(101);
account1.Notify1 += mes => Console.WriteLine(mes);
account1.Notify2 += mes =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(mes);
    Console.ResetColor();
};
account1.Put(200);

void DisplayMessage(string message) => Console.WriteLine(message);
class Account
{
    public delegate void AccountHandler(string message);
    public event AccountHandler Notify1;
    public event AccountHandler Notify2;
    public int Sum { get; private set; }
    public Account(int sum) => Sum = sum;
    public void Put(int sum)
    {
        Sum += sum;
        Notify1?.Invoke($"На счет поступило: {sum}");
        Notify2?.Invoke($"Баланс счета: {Sum}");
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify1?.Invoke($"Со счета списано: {sum}");
            Notify2?.Invoke($"Баланс счета: {Sum}");
        }
        else
        {
            Notify1?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}");
            Notify2?.Invoke($"Баланс счета: {Sum}");
        }
    }
}


//----------------------------------------------------------------------------------------
//Account acc = new Account(100);
//acc.Notify1 += DisplayMessage;
//acc.Put(20);
//acc.Notify1 -= DisplayMessage;
//acc.Put(20);

//void DisplayMessage(string message)=> Console.WriteLine(message);

//class Account
//{
//    public delegate void AccountHandler(string message);
//    AccountHandler? notify1;
//    public event AccountHandler Notify1
//    {
//        add
//        { 
//            notify1 += value;
//            Console.WriteLine($"{value.Method.Name} добавлен");
//        }
//        remove
//        { 
//            notify1 -= value;
//            Console.WriteLine($"{value.Method.Name} удален");
//        }
//    }
//    public int Sum { get; private set; }
//    public Account(int sum) => Sum = sum;
//    public void Put(int sum)
//    {
//        Sum += sum;
//        notify1?.Invoke($"На счет поступило: {sum}");
//    }
//    public void Take(int sum)
//    {
//        if (Sum >= sum)
//        {
//            Sum -= sum;
//            notify1?.Invoke($"Со счета списано: {sum}");
//        }
//        else
//        {
//            notify1?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}");
//        }
//    }
//}

//------------------------------------------------------------------------------------
//Account acc = new Account(100);
//acc.Notify += DisplayMessage;
//acc.Put(20);
//acc.Take(70);
//acc.Take(150);
//void DisplayMessage(Account sender, AccountEventArgs e)
//{
//    Console.WriteLine($"Сумма транзакции: {e.Sum}");
//    Console.WriteLine(e.Message);
//    Console.WriteLine($"Текущая сумма на счете: {sender.Sum}");
//}
//class Account
//{
//    public delegate void AccountHandler(Account sender, AccountEventArgs e);
//    public event AccountHandler Notify;
//    public int Sum { get; private set; }
//    public Account(int sum) => Sum = sum;
//    public void Put(int sum)
//    {
//        Sum += sum;
//        Notify?.Invoke(this, new AccountEventArgs($"На счет поступило: {sum}", sum));
//    }
//    public void Take(int sum)
//    {
//        if (Sum >= sum)
//        {
//            Sum -= sum;
//            Notify?.Invoke(this, new AccountEventArgs($"Со счета списано: {sum}", sum));
//        }
//        else
//        {
//            Notify?.Invoke(this, new AccountEventArgs($"Недостаточно денег на счете. Текущий баланс: {Sum}", Sum));
//        }
//    }
//}

//class AccountEventArgs
//{
//    public string Message { get; }
//    public int Sum { get; }
//    public AccountEventArgs(string message, int sum)
//    {
//        Message = message;
//        Sum = sum;
//    }
//}