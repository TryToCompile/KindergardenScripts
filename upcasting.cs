Employee employee = new Employee("Tom", "Microsoft");
Person person = employee;   // преобразование от Employee к Person
// person, created from employee to Person have no access to Employee part of heap
// 
// У нас есть более широкий клас Employee, мы создаем эдакий Persоn employee,
// который называем person, он имеет доступ только к области памяти в куче,
// имеющей отношение к person
// employee же, в свою очередь, имеет доступ и в Person и в Employee
Console.WriteLine(person.Name);


class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine($"Person {Name}");
    }
}

class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
}

class Client : Person
{
    public string Bank { get; set; }
    public Client(string name, string bank) : base(name)
    {
        Bank = bank;
    }
}

