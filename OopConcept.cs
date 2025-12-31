using System;
class Class1
{
    string color = "red";

    void MyMethod()
    {
        Console.WriteLine("My car color is white");
    }

    static void Main(string[] args)
    {
        Class1 myObj = new Class1();
        Class1 myObj2 = new Class1();


        Console.WriteLine(myObj2.color);

        Console.WriteLine(myObj.color);

        myObj.MyMethod();


    }
}

