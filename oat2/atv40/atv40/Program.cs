using System;

class Program
{
    private static double primerio, segundo;
    static void Main(string[] args)
    {
        double numero;
        bool parar = false;
        char letra;

        do
        {
            do
            {
                Console.Write("Digite o índice de poluição: ");
                numero = double.Parse(Console.ReadLine());  
                if (numero < 0) Console.Write("Número inválido digite um número positivo.");
            } while (numero < 0);

            Console.Write(" ");

            if (numero >= 0 && numero <= 0.25)
            {
                Console.Write("Índice de poluição aceitável.");
            }


            if (numero >= 0.3)
            {
                Console.Write("Suspender atividades das indústrias do 1° Grupo!\n");
            }

            if (numero >= 0.4)
            {
                Console.Write("Suspender atividades das indústrias do 2° Grupo!\n");
            }

            if (numero >= 0.5)
            {
                Console.Write("Suspender atividades das indústrias do 3° Grupo!\n");
            }

            Console.Write("\nDeseja encerrar o programa? (s/N) ");
            letra = char.Parse(Console.ReadLine());
            if (letra == 's' || letra == 'S')
            {
                parar = true;
            }

        } while (parar == false);

    }
}