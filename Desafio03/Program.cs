using System;
class minhaClasse
{
    static void Main(string[] args)
    {
        double nota;
        int qtdIgual = 0;
        double soma = 0;
        while (qtdIgual != 2)
        {
            nota = Convert.ToDouble(Console.ReadLine());
            if (nota >= 0 && nota <= 10)  //complete a condicional
            {
                soma = nota + soma;
                qtdIgual++;
            }
            else
            {
                Console.WriteLine("nota invalida");
            }
        }
        Console.WriteLine("media = " + (soma/2).ToString("N2")); //insira a variavel correta
    }
}