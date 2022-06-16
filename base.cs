using System;
using System.Globalization;
using static System.Console;


Person person = new Person("Bob");
person.Print();     // Bob
Employee employee = new Employee("Tom", "Microsoft");
employee.Print();   // Tom



class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
        WriteLine("I'm on!");
    }
    public void Print()
    {
        WriteLine(Name);
    }
}

class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company)
        : base(name) // just makes (Name = name; WriteLine();) here
    {
        Company = company;
    }
}
