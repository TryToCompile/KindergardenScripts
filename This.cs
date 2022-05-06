using HelloWorld;
using System;
using System.Globalization;

Person Adam = new();
Person Luck = new("Luck");
Person Nami = new("Nami", 3);

Adam.name = "Adam";
Adam.Print();
Luck.Print();
Nami.Print();

class Person
{
    public string? name; 
    public int? age;

    public Person()
    {
        name = "Undefined";
        age = 1;
        Console.WriteLine("Constructor!");
    }

    public Person(string name)
    {
        this.name = name; // LUCK.NAME = "LUCK"
        age = 2;
    }

    public Person(string name, int age)
    {
        this.name = name; // NAMI.NAME = "NAMI"
        this.age = age;   // NAMI.AGE = AGE
    }

    public void Print()
    {
        Console.WriteLine($"{name} is {age}!");
    }
}
