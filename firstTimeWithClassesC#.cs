using System;
using System.Globalization;

public class Person
{
    public string name = "Undefined";
    public int age;

    static void Main(string[] args)
    {
        var person = new Person();
        person.Print();
        var car = new Car();
        car.Check();
        car.CarPrinter();
        Console.WriteLine(car.chinaEngine);
    }

    void Print()
    {
        Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
}

class Car
{
    public string chinaEngine = "undefined";
    public string americanEngine = "undefined";

    public void Check()
    {
        if (chinaEngine == "undefined")
        {
            chinaEngine = "american";
            Console.WriteLine(chinaEngine);
        }
    }

    public void CarPrinter()
    {
        chinaEngine = "chinese";
    }
}
