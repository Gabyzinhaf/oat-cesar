using System.CodeDom.Compiler;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[10];
        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Digite o " + (x + 1) + "o Numero do vetor: ");
            vetor[x] = Int32.Parse(Console.ReadLine());
        }

        int numeroX;
        Console.WriteLine("Digitei o numero X: ");
        numeroX = Int32.Parse(Console.ReadLine());

        int maiores = 0, menores = 0, iguais = 0;
        Console.WriteLine("Numeros maiores que o numeroX:\n ");
        for (int w = 0; w < 10; w++)
        {
            if (vetor[w] > numeroX)
            {
                Console.WriteLine(vetor[w]);
                maiores++;
            }
            else if (vetor[w] == numeroX)
            {
                iguais++;
            }
            else
            {
                menores++;
            }

            Console.WriteLine("\nMaiores: " + maiores + "\nIguais: " + iguais + "\nMenores: " + menores + "\n");
        }
    }
}