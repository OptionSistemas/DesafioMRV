using System;

class minhaClasse
{

    static void Main(string[] args)
    {
        decimal[] notas = { 100, 50, 20, 10, 5, 2};
        decimal[] moedas = { 1, 0.5m, 0.25m, 0.10m, 0.05m, 0.01m};

        decimal valor;
        valor = decimal.Parse(Console.ReadLine());
        // calculando as notas
        Console.WriteLine("NOTAS:");
        for (int i = 0; i < notas.Length; i++){
            Console.WriteLine("{0} nota(s) de R$ {1}", (int)(valor / notas[i]), notas[i].ToString("N2").Replace(",",".")) ;
            valor = valor % notas[i];
        }
        // calculando as moedas
        Console.WriteLine("MOEDAS:");
        for (int i = 0; i < moedas.Length; i++)
        {
            Console.WriteLine("{0} moeda(s) de R$ {1}", (int)(valor / moedas[i]), moedas[i].ToString("N2").Replace(",", "."));
            valor = valor % moedas[i];
        }

    }

}