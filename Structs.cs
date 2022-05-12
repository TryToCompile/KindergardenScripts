using System;
using System.Globalization;
using static Programs;

Personale Adams = new();

Adams.name = "Adams";
Adams.Print();


class Programs
{

    /*static void Main(string[] args)
    {

    }*/

   
    
    
    
    public struct Personale
    {
        public string name;
        public int age;
        public void Print()
        {
          Console.WriteLine($"name:{name} and age:{age}");
        }
    }
}
