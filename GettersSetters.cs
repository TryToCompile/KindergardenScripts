using System;
using System.Globalization;


Car Ford = new();
Ford.TirePressure = 4;
Ford.Print();
Ford.EngineStart();

Ford.TirePressure = 5;
Ford.Print();
Ford.EngineStart();

Person person = new();
person.Try();
class Car
{
    private float tirePressure = 10.5f;
    private float speed = 4.8f;

    public void EngineStart()
    {
        if (tirePressure > 4)
        {
            Console.WriteLine("Started!");  
        } else
        {
            Console.WriteLine("Not started!!!");
        }
    }
    public float Speed
    {
        get { return speed; }
    }

    public float TirePressure
    {
        set { tirePressure = value; }
    }

    public void Print() => Console.WriteLine($"TP is {tirePressure} and speed is {Speed}");
}

class Person
{
    public void Try()
    {
        Car car = new();
        car.TirePressure = 6;
        car.Print();
        car.EngineStart();
    }
}
