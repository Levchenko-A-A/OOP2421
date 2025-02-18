using System.Linq;
using System.Security.Cryptography.X509Certificates;



List<Car> GetCars()
{
    return new List<Car>
    {
        new Car {VIN = "ABC123", Make = "Ford", Model = "F-250", Year  =2000},
        new Car {VIN = "DEF123", Make = "BMW", Model = "Z-3", Year  = 2005 },
        new Car {VIN = "ABC456", Make = "Audi", Model = "TT", Year  = 2008 },
        new Car {VIN = "HIJ123", Make = "VW", Model = "Bug", Year  = 1956 },
        new Car {VIN = "DEF456", Make = "Ford", Model = "F-150", Year  = 1998 },
    };
}

bool result = GetCars().All(c => c.Year > 1960);
Console.WriteLine(result);
result = GetCars().Any(c => c.Year > 1960);
Console.WriteLine(result);

var cars = GetCars();
var carsByVin = cars.ToDictionary(c => c.VIN);
Console.WriteLine(carsByVin["ABC123"].Make);
var carsLookUp = cars.ToLookup(c => c.Make);
IEnumerable<Car> list = carsLookUp["Ford"];
foreach(var car in list)
    Console.WriteLine(car.Year);

var numbers = Enumerable.Range(1, 1000);
//foreach(var number in numbers)
//    Console.WriteLine(number);
var zip = numbers.Zip(cars, (i, c) => new
{
    Number = i,
    CarMake=c.Make,
});
foreach(var car in zip)
    Console.WriteLine(car);

class Car
{
    public string? VIN {  get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public string? Color { get; set; }
}