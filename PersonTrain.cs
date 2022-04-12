using System;
using System.Globalization;



Person Adam = new();
Adam.PersonConsoleLog();
Person Andy = new("Minsk", 15);
Person Ory = new("Hrodna",100);
Andy.PersonConsoleLog();
Ory.PersonConsoleLog();
class Person
{
    public string? name;
    public int age;
    public int id;
    public string? email;
    public string? phone;
    public string? city;
    private string? _card;

    public Person()
    {
        name = "undefined";
        age = 0;
        id = 0;
        email = "undefined";
        phone = "undefined";
        city = "undefined";
        _card = "undefined";
    } 

    public Person(string city, int age)
    {
        name = Console.ReadLine();
        this.city = city;
        this.age = age;
    }

    public void PersonConsoleLog()
    {
        Console.WriteLine($"Name: [{name}], city [{city}], age [{age}], card [{_card}]");
    }
}
