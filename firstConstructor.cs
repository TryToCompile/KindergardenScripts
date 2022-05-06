using System;
using System.Globalization;


Person Tom = new();
Person Lana = new("lana", 19);

Lana.Print();
Tom.Print();


class Person
{
    public string ?Name = "Undefined";
    public int ?age = 0;
    public Person() // Happens only when we declaring an object
    {
        Console.WriteLine("It's 1 constructor! Input name:");
        Name = Console.ReadLine();
        Console.WriteLine("Input age:");
        age = int.Parse(Console.ReadLine());
    }
    
    public Person(string name,int age)
    {
        Console.WriteLine("It's 2 constructor!");
    }


    public void Print()
    {
        if (Name != "Undefined")
        {
            Console.WriteLine($"{Name} is {age}.");
        } else
        {
            age = 0;
            Console.WriteLine($"{Name} person is {age}.");
        }
        
    }
}
