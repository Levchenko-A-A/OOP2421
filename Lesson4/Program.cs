using Lesson4;

//Massiv2D ourMas = new Massiv2D(4, 7);
//ourMas.Fill();
//for (int i = 0; i < ourMas.Rows; i++)
//{
//    for (int j = 0; j < ourMas.Cols; j++)
//    {
//        Console.Write(ourMas[i,j]+" ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("Количество разных элементов: "+ourMas.Different());

//User Tom = new User();
//Tom["name"] = "Tom";
//Tom["email"] = "Tom@mail.ru";
//Tom["phone"] = "+7909.....";

//Console.WriteLine(Tom["name"]+" " + Tom["email"]+" " + Tom["phone"]);

Rocket rocket = new Rocket()
{
    TypeFuel = TypeOfFuel.Гелеобразное,
    Volume1 = 10, 
    Volume2 = 20, 
    Volume3 = 30,
    Speed1=20, 
    Speed2 = 40,
    Speed3 = 60, 
    Time1 = 10, 
    Time2 = 20, 
    Time3 = 30
};

Console.WriteLine(rocket.SpeedTime(5));
Console.WriteLine(rocket.SpeedTime(15));
Console.WriteLine(rocket.SpeedTime(25));

Console.WriteLine(rocket.Time());

if(rocket.NumberStep(45)!=-1) Console.WriteLine(rocket.NumberStep(45));
else Console.WriteLine($"Отбитальный полет и время полета {45-rocket.Time()}");