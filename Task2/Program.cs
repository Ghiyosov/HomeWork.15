using Task2;

var dog = new Dog();

while(true)
{
    System.Console.WriteLine("What's the dog's name");
    dog.SetName(Console.ReadLine());
    System.Console.WriteLine($"{dog.GetName()}'s good dog");
    System.Console.WriteLine($"if you want to feed {dog.GetName()}, enter feed");
    string feed = Console.ReadLine();
    feed = feed.ToLower();
    if (feed == "feed") dog.Eat();
    System.Console.WriteLine("-------------------------------");
    System.Console.WriteLine();
    System.Console.WriteLine();
}