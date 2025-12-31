using System;
public class Vehicle
{

	public string color = "red";
	public void honk()
	{
		Console.WriteLine("Animal");
	}
}

public class Car : Vehicle
{
	public void show()
	{
		Console.WriteLine("Birds");
	}
}



class Class1
{
	static void Main(string[] args)
	{
		Car myObj = new Car();

		Console.WriteLine(myObj.color);
		myObj.honk();


	}
}
