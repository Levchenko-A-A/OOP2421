using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Базовый класс Животное
abstract class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public abstract string Type { get; }
    public abstract double CalculateFood();

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Type: {Type}, Food needed: {CalculateFood()}";
    }
}

// Потомок класса Животное - Хищник
class Carnivore : Animal
{
    public override string Type => "Carnivore";
    public override double CalculateFood()
    {
        return 2.5; // Для примера, у хищников количество пищи пропорционально больше
    }
}

// Потомок класса Животное - Всеядное
class Omnivore : Animal
{
    public override string Type => "Omnivore";
    public override double CalculateFood()
    {
        return 1.5; // Для примера, всеядные животные потребляют среднее количество пищи
    }
}

// Потомок класса Животное - Травоядное
class Herbivore : Animal
{
    public override string Type => "Herbivore";
    public override double CalculateFood()
    {
        return 1.0; // Для примера, у травоядных животных количество пищи меньше
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Carnivore { Id = 1, Name = "Tiger" },
            new Omnivore { Id = 2, Name = "Bear" },
            new Herbivore { Id = 3, Name = "Elephant" }
        };

        // Сортировка по убыванию количества пищи, затем по имени
        animals = animals.OrderByDescending(a => a.CalculateFood()).ThenBy(a => a.Name).ToList();

        // Вывод информации о животных
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }

        Console.WriteLine();

        // Вывод первых 5 имен животных
        Console.WriteLine("First 5 animal names:");
        foreach (var animal in animals.Take(5))
        {
            Console.WriteLine(animal.Name);
        }

        Console.WriteLine();

        // Вывод последних 3 идентификаторов животных
        Console.WriteLine("Last 3 animal ids:");
        foreach (var animal in animals.TakeLast(3))
        {
            Console.WriteLine(animal.Id);
        }

        // Запись коллекции в файл
        using (StreamWriter writer = new StreamWriter("animals.txt"))
        {
            foreach (var animal in animals)
            {
                writer.WriteLine($"{animal.Id},{animal.Name},{animal.Type},{animal.CalculateFood()}");
            }
        }

        // Чтение коллекции из файла
        List<Animal> animalsFromFile = new List<Animal>();
        try
        {
            using (StreamReader reader = new StreamReader("animals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()!) != null)
                {
                    string[] parts = line.Split(",");
                    Animal newAnimal;
                    if (parts[2] == "Carnivore")
                    {
                        newAnimal = new Carnivore();
                    }
                    else if (parts[2] == "Omnivore")
                    {
                        newAnimal = new Omnivore();
                    }
                    else if (parts[2] == "Herbivore")
                    {
                        newAnimal = new Herbivore();
                    }
                    else
                    {
                        throw new Exception("Invalid animal type");
                    }

                    newAnimal.Id = int.Parse(parts[0]);
                    newAnimal.Name = parts[1];
                    animalsFromFile.Add(newAnimal);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        foreach (var animal in animalsFromFile)
        {
            Console.WriteLine(animal);
        }
    }
}


public int Id { get; set; }
public string? Name { get; set; }
public abstract double Weight { get; set; }
public int Age { get; set; }
public abstract string? TypeOfFood { get; }
public abstract double NormOnePer { get; set; }
public abstract double FoodQuantity { get; }