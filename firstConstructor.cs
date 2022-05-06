using System;
using System.Globalization;


Person Tom = new Person();

Tom.Print();


class Person
{
    public string ?Name = "Undefined";
    public int ?age = 0;
    public Person() // Happens only when we declaring an object
    {
        Console.WriteLine("It's constructor! Input name:");
        Name = Console.ReadLine();
        Console.WriteLine("Input age:");
        age = int.Parse(Console.ReadLine());
    }


    public void Print()
    {
        Console.WriteLine($"{Name} is {age}.");
    }
}
