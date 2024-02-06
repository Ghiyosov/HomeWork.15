




using Task._1;
var car = new Car();
while (true)
{
    System.Console.WriteLine("to refuel, enter refuel");
    System.Console.WriteLine("to go, enter go");
    string driv = Console.ReadLine();
    driv = driv.ToLower();
    
    string driver = driv switch
    {
        "refuel" =>Refuels(car),
        "go"=>Drives(car),
        _=>"0"
        
    };
}
string Drives(Car car)
{
    car.Drive();
    return"go";    
}

string Refuels(Car car)
{
    int b = Convert.ToInt32(Console.ReadLine());
    car.Refuel(b);
    return "car is refuels";

}