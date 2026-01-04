using System;

class Class1
{
	static void Main(string[] args)
	{
		string result = "He is a very very good boy, isn't he?";



		string[] car = result.Split(
			new char[] { ' ', ',', '?', '!' },
			StringSplitOptions.RemoveEmptyEntries
		);

		Console.WriteLine(car.Length);

		foreach (string i in car)
		{
			Console.WriteLine(i);
		}



	}
}

