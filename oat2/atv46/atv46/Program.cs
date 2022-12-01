class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite a quantidade de numeros");
        int qtd = Int32.Parse(Console.ReadLine());

        int[] vetorX = new int[qtd];
        int[] vetorY = new int[qtd];

        for(int x = 0; x < qtd; x++)
        {
            Console.WriteLine("Digite o " + (x + 1) + "o Numero do vetor X");
            vetorX[x] = Int32.Parse(Console.ReadLine());
        }

        for (int y = 0; y < qtd; y++)
        {
            Console.WriteLine("Digite o " + (y + 1) + "o Numero do vetor Y");
            vetorY[y] = Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine("A multiplicacao dos vetores eh: \n");
        for(int w = 0; w < qtd; w++)
        {
            Console.WriteLine(vetorX[w]+" * " + vetorY[w]+" = " + (vetorX[w] * vetorY[w]));
        }

    }
}