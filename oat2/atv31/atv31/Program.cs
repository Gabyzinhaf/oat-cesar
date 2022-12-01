using System;

class Program
{
    static void Main(string[] args)
    {
        int Numero = 0, QuantPar = 0, QuantImpar = 0;

        while (Numero >= 0)
        {

            Console.WriteLine("Digite um número (numeros negativos finalizam): ");
            Numero = Int32.Parse(Console.ReadLine());
            if (Numero >= 0)
            {
                if (Numero % 2 == 0)
                {
                    QuantPar++;
                }
                else
                {
                    QuantImpar++;
                }
            }
        }

        Console.WriteLine("\n\nQuantidade de Números Pares: " + QuantPar + "\nQuantidade de Números Impares: " + QuantImpar);

    }
}
