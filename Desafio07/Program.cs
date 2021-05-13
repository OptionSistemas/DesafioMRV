using System;

class minhaClasse
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split();
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int q, r;

        q = a / b;
        r = (a % b);

        if (r < 0)
        {
            r = r + Convert.ToInt32(Math.Sqrt(b * b));
            q = (a - r) / b;
        }
        Console.WriteLine("{0} {1}", q, r);
    }
}