using System;
using System.Collections.Generic;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Тварина: {Name}, Вiк: {Age}");
    }
}

class Mammal : Animal
{
    public bool HasFur { get; set; }

    public Mammal(string name, int age, bool hasFur) : base(name, age)
    {
        HasFur = hasFur;
    }

    public override void Show()
    {
        Console.WriteLine($"Савець: {Name}, Вiк: {Age}, Має шерсть: {(HasFur ? "так" : "нi")}");
    }
}

class Ungulate : Animal
{
    public bool HasHooves { get; set; }

    public Ungulate(string name, int age, bool hasHooves) : base(name, age)
    {
        HasHooves = hasHooves;
    }

    public override void Show()
    {
        Console.WriteLine($"Парнокопитне: {Name}, Вiк: {Age}, Має копита: {(HasHooves ? "так" : "нi")}");
    }
}

class Bird : Animal
{
    public bool CanFly { get; set; }

    public Bird(string name, int age, bool canFly) : base(name, age)
    {
        CanFly = canFly;
    }

    public override void Show()
    {
        Console.WriteLine($"Птах: {Name}, Вiк: {Age}, Може лiтати: {(CanFly ? "так" : "нi")}");
    }
}


class Romb
{
    // Поля
    protected int a; // сторона
    protected int d1; // дiагональ
    private readonly string color; // колiр ромба

    // Конструктор
    public Romb(int side, int diagonal, string color)
    {
        this.a = side;
        this.d1 = diagonal;
        this.color = color;
    }

    // Властивостi
    public int Side
    {
        get { return a; }
        set { a = value; }
    }

    public int Diagonal
    {
        get { return d1; }
        set { d1 = value; }
    }

    public string Color
    {
        get { return color; }
    }

    // Методи
    public void PrintLengths()
    {
        Console.WriteLine($"Сторона: {a}");
        Console.WriteLine($"Дiагональ: {d1}");
    }

    public int CalculatePerimeter()
    {
        return 4 * a;
    }

    public double CalculateArea()
    {
        return a * d1 / 2.0;
    }

    public bool IsSquare()
    {
        return a == d1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Оберiть завдання:");
        Console.WriteLine("1. Iєрархiя класiв");
        Console.WriteLine("2. Робота з класом Romb");

        char choice = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (choice)
        {
            case '1':
                RunAnimalTask();
                break;
            case '2':
                RunRombTask();
                break;
            default:
                Console.WriteLine("Невiдомий вибiр. Будь ласка, виберiть 1 або 2.");
                break;
        }
    }

    static void RunAnimalTask()
    {
        List<Animal> animals = new List<Animal>();

        animals.Add(new Mammal("Ведмiдь", 5, true));
        animals.Add(new Ungulate("Олень", 3, true));
        animals.Add(new Bird("Синиця", 2, true));

        Console.WriteLine("Масив тварин:");
        foreach (Animal animal in animals)
        {
            animal.Show();
        }
    }

    static void RunRombTask()
    {
        // Створення масиву ромбiв
        Romb[] rombs = new Romb[3];
        rombs[0] = new Romb(3, 5, "червоний");
        rombs[1] = new Romb(4, 4, "синiй"); // цей ромб - квадрат
        rombs[2] = new Romb(2, 6, "зелений");

        // Виведення iнформацiї про кожен ромб
        for (int i = 0; i < rombs.Length; i++)
        {
            Console.WriteLine($"Ромб {i + 1}:");
            rombs[i].PrintLengths();
            Console.WriteLine($"Периметр: {rombs[i].CalculatePerimeter()}");
            Console.WriteLine($"Площа: {rombs[i].CalculateArea()}");
            Console.WriteLine($"Квадрат? {(rombs[i].IsSquare() ? "Так" : "Нi")}");
            Console.WriteLine($"Колiр: {rombs[i].Color}");
            Console.WriteLine();
        }

        // Пiдрахунок кiлькостi квадратiв
        int squareCount = 0;
        foreach (Romb romb in rombs)
        {
            if (romb.IsSquare())
                squareCount++;
        }
        Console.WriteLine($"Кiлькiсть квадратiв: {squareCount}");
    }
}
