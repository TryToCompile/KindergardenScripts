using System;
using System.Globalization;
using static Programs;

Personale Adams = new();
Personale Thomas = new("Thomas",10);
Personale Mars = new("Mars");
Personale Persi = new() { name = "Persi"};

Adams.name = "Adams";
Adams.Print();
Adams.EditName();
Adams.Print();

Thomas.Print();
Mars.Print();
Persi.Print();

Persi.EditName();
Persi.EditAge();
Persi.Print();
class Programs
{
    public struct Personale
    {
        public string ?name;
        public int ?age;
        public void Print()
        {
          Console.WriteLine($"name:{name} and age:{age}");
        }

        public void EditName()
        {
            Console.WriteLine("Input name:");
            name = Console.ReadLine();
        }

        public void EditAge()
        {
            Console.WriteLine("Input age:");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public Personale(string name, int age = 1)
        {
            this.name = name;
            this.age = age;
        }
    }
}
