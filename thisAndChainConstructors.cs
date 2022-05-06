using System;
using System.Globalization;

Person Adam = new();
Console.WriteLine("first iter ====================================");
Person Luck = new("Luck");
Console.WriteLine("second iter ===================================");
Person Nami = new("Nami", 3);
Console.WriteLine("third iter ===================================");
Adam.name = "Adam";
Adam.Print();
Luck.Print();
Nami.Print();

class Person
{
    public string name;
    public int age;
    public Person() : this("Неизвестно")    // will be third constructor, then second, and then first
    { Console.WriteLine($"1 constructor{name} {age}"); }
    public Person(string name) : this(name, 18) // will be third constructor, and then second
    { Console.WriteLine($"2 constructor{name} {age}"); }
    public Person(string name, int age)     // will be only third constructor
    {
        this.name = name;
        this.age = age;
        Console.WriteLine($"3 constructor{name} {age}");
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}
