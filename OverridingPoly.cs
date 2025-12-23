using System;

public class Vehicle
{

    public string color = "red";
    public virtual void honk()
    {
        Console.WriteLine("BMW");
    }
}

public class Car : Vehicle
{
    public void honk()
    {
        Console.WriteLine("VOLVO");
    }
}

public class Truck : Vehicle
{
    public override void honk()
    {
        Console.WriteLine("Mahindra Truck");
    }
}



class Class1
{
    static void Main(string[] args)
    {
        Car myObj = new Car();

        Console.WriteLine(myObj.color);
        myObj.honk();

        Vehicle vehicle = new Truck();
        vehicle.honk();


    }

}
