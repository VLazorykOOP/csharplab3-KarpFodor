using System;
using System.Collections.Generic;
using System.Linq;

// Базовий клас
class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void Show()
    {
        Console.WriteLine($"Ім'я: {Name}, Вік: {Age}");
    }
}

// Похідний клас для савців
class Mammal : Animal
{
    public string FurColor { get; set; }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Колір шерсті: {FurColor}");
    }
}

// Похідний клас для птахів
class Bird : Animal
{
    public double Wingspan { get; set; }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Розмах крил: {Wingspan}");
    }
}

// Похідний клас для плазунів
class Reptile : Animal
{
    public bool IsVenomous { get; set; }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Отруйний: {(IsVenomous ? "Так" : "Ні")}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення масиву тварин
        Animal[] animals = new Animal[4];

        // Наповнення масиву об'єктами різних класів
        animals[0] = new Mammal { Name = "Ведмідь", Age = 10, FurColor = "Коричневий" };
        animals[1] = new Bird { Name = "Сова", Age = 5, Wingspan = 0.6 };
        animals[2] = new Reptile { Name = "Кобра", Age = 3, IsVenomous = true };
        animals[3] = new Mammal { Name = "Тигр", Age = 8, FurColor = "Полосатий" };

        // Виведення масиву впорядкованого за віком
        Console.WriteLine("Масив впорядкований за віком:");
        var sortedByAge = animals.OrderBy(a => a.Age);
        foreach (var animal in sortedByAge)
        {
            animal.Show();
        }
    }
}
