using System;
using static System.Console;


class Program
{
    static void Main(string[] args)
    {
        Base derivedAsBase = new Derived(); // Тут  мы создаем переменную с типом родителя, присваивая ей объект с типом наследника, переопределяем.
        Derived derived = new Derived(); // А тут все чисто

        derivedAsBase.First();  // Derived.First(), выведет "First from Derived"                
        derivedAsBase.Second(); // Base.Second(), выведет "Second from Base"
        derived.First();  // Derived.First(), выведет "First from Derived" 
        derived.Second(); // Derived.Second(), выведет "Second from Derived"  потому что мы скрыли метод Second от родителя с помощью (new), в итоге
                          // Переменная класса Base не видит скрытый метод, а переменная класса, в котором этот метот и находится, уже видит его.
        Console.ReadLine();
    }
}

class Base
{
    public virtual void First()
    {
        Console.WriteLine("First from Base");
    }

    public virtual void Second()
    {
        Console.WriteLine("Second from Base");
    }
}

class Derived : Base
{
    public override void First()
    {
        Console.WriteLine("First from Derived");
    }

    public new void Second()
    {
        Console.WriteLine("Second from Derived");
    }
}