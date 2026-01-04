using System;

class Class1
{
    static void Main(string[] args)
    {
        string word = "welcometojava";
        int k = 3;

        string largest = word.Substring(0, k);
        string smallest = word.Substring(0, k);


        for (int i = 0; i <= word.Length - k; i++)
        {
            string current = word.Substring(i, k);

            if (current.CompareTo(smallest) < 0)
            {
                smallest = current;
            }
            if (current.CompareTo(largest) > 0)
            {
                largest = current;
            }

        }

        Console.WriteLine(smallest);
        Console.WriteLine(largest);
    }
}
