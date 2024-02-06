namespace Task._1;

public class Car : IVehicle
{
    int _refuel;
    public Car(int refuel)
    {
        _refuel = refuel;
    }
    public Car()
    {
        
    }
    public void AddRefuel(int refuel)
    {
        _refuel = _refuel + refuel;
    }
    public void Drive()
    {
        if (_refuel > 0) System.Console.WriteLine("Driving");
        else System.Console.WriteLine("gasoline is zero");
    }
    //Метод Refuel должен увеличивать количество бензина в автомобиле и возвращать true
    public bool Refuel(int refuel)
    {

        _refuel = _refuel + refuel;
       return true;
    }

}
