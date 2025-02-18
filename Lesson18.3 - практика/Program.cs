using System.Reflection.Metadata.Ecma335;
int x = 0;
Car car1 = new Car(x, 2, 1);
Car car2 = new Car(x, 3, 2);
Thread thread1 = new Thread(car1.inc);
Thread thread2 = new Thread(car2.inc);
thread1.Start();
//thread1.Join();
thread2.Start();
class Car
{
    private int x;
    private int s;
    private int number;
    public Car(int _x, int speed, int number)
    {
        this.x = _x;
        this.s = speed;
        this.number = number;
    }
    public void inc()
    {
        for (int i = 0; i < 50; i++)
        {
            x += s;
            Thread.Sleep(100);
            Console.WriteLine($"{number} : {getX()}");

        }
    }
    public int getX() => x;
}


//using System.Reflection.Metadata.Ecma335;
//int x = 30;
////Mutex mutexObj = new();
//Car car1 = new Car(x, 1);
////Car car2 = new Car(x, 2);
//Thread thread1 = new Thread(car1.inc, 1);
//Thread thread2 = new Thread(car1.dec, 2);
//thread1.Start();
//thread1.Join();
//thread2.Start();
//class Car
//{
//    private int x;
//    private int number;
//    public Car(int _x, int number)
//    {
//        this.x = _x;
//        this.number = number;
//    }
//    public void inc()
//    {
//        //mutexObj.WaitOne();
//        for (int i = 0; i < 50; i++)
//        {
//            x += 1;
//            Thread.Sleep(100);
//            Console.WriteLine($"{number} : {getX()}");

//        }
//        //mutexObj.ReleaseMutex();
//    }
//    public void dec()
//    {
//        //mutexObj.WaitOne();
//        for (int i = 0; i < 50; i++)
//        {
//            x -= 1;
//            Thread.Sleep(100);
//            Console.WriteLine($"{number} : {getX()}");

//        }
//        //mutexObj.ReleaseMutex();
//    }
//    public int getX() => x;
//}