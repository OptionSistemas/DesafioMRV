using System;

class minhaClasse
{

    static void Main(string[] args)
    {

        int a, b, x;
        string[] values = Console.ReadLine().Split(' ');

        a = Convert.ToInt32(values[0]);
        b = Convert.ToInt32(values[1]);
        x = a + b;
        Console.WriteLine("X = {0}", x);

    }

}