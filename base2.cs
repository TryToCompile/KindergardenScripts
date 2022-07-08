using System;

/* Вариант с включенным конструктором без параметров можно использовать, когда у нас 
   какой-то из параметров задан однозначно, в примере - Age.
   В ином случае, используем передачу через Base*/ 
Human Norman = new("Norman");
Norman.Walk();


Police Cop = new Police(30,"cops");
Cop.CallThePolice();
Cop.Walk();

class Human
{
    public int Age { get; set; }
    public string Name { get; set; }
/*    
    public Human()
    {
        Age = 5;
    } 
*/  

    public Human(string name)
    {
        Name = name;
    }

    public Human(int Age,string Name)
    {

    }
    virtual public void Walk()
    {
        Console.WriteLine("Walking");
    
    }
}

class Police : Human
{
    public Police(int age, string name)
        : base(name)
    {
        Age = age;
    }

    public override void Walk()
    {
        Console.WriteLine("Cop Walking");
    }

    public void CallThePolice()
    {
        Console.WriteLine($" { Age } + { Name} ");
    }
}
