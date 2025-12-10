// See https://aka.ms/new-console-template for more information
class Program{

    static int MyMethod(int x , int y)
    {
        return x + y;
    }

    static void MyMethod(int z1)
    {
        Console.WriteLine(z1);
    }

    static float MyMethod(float z2)
    {
        return z2 + 2.55f;
    }

    static double MyMethod(double z3)
    {
        return z3 + 5.264d;
    }

    static double MyMethod(double z4,double z5)
    {
        return z4 + 7.54;
    }
 static void Main(string[] args)
    {
        int z = MyMethod(5,2);
        Console.WriteLine(z);
        MyMethod(1);
        Console.WriteLine(MyMethod(2.55f));
        Console.WriteLine(MyMethod(3.54D));
        Console.WriteLine(MyMethod(1.25D,8.54D));
    }    

}
