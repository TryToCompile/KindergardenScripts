using System;
using System.Globalization;
using static System.Console;



Person Tom = new() { Name = "Tom"};
WriteLine(Tom.Name);

Junior Adam = new();
Adam.Method();

class Person
{
    private string? _name = "";

    public string? Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public void Print()
    {
        Console.WriteLine(Name);
    }
}

class Junior : Person
{
       public void Method()
    {
        WriteLine("Input your name:");
        Name = ReadLine();
        WriteLine($"Hi, {Name}!");
    }
}
