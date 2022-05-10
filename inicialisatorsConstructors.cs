using System;
using System.Globalization;



Person tom = new() { age = 100, name = "Thomas"};
tom.PrintName();
tom.FullPrint();
Person thomas = new() { company = { title = "GooGle", hired = "yes", salary = 100, workers = 10 }, age = 15, name = "Thomas" };
thomas.FullPrint();

(string name, int age) = thomas; // deconstruction

Console.WriteLine($"{name} { age}");
class Person
{
    public string name;
    public int age;
    public Company? company;

    public Person()
    {
        name = "undef";
        age = 100;
        company = new Company();
    }
    public void PrintName()
    {
        Console.WriteLine($"{name} is {age}!");
    }

    public void FullPrint()
    {
        Console.WriteLine($"{name}\t {age}\t {company.title}\t {company.salary}\t {company.workers}\t {company.hired}\t");
    }

    public void Deconstruct(out string nameOut, out int ageOut) // deconstruction
    {
        nameOut = name;
        ageOut = age;
    }
}
