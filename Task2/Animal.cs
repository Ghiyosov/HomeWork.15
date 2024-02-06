namespace Task2;

public abstract class Animal
{
    public abstract string Name { get; set; }
    public abstract void SetName(string name);
    public abstract string GetName();
    public abstract void Eat();
}
