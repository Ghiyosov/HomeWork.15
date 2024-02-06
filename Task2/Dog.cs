namespace Task2;

public class Dog : Animal
{
    public override string Name { get; set; }
    public override void SetName(string name)
    {
        Name = name;
    }
    public override string GetName()
    {
        return Name;
    }
    public override void Eat()
    {
        System.Console.WriteLine($"Dog {Name} is eating");
    }
}
