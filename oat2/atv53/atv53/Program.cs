class Program
{
    static void Main(string[] args)
    {
        int numeroVoltas, total = 0, media, melhorTempo = 0, melhorVolta = 0;

        Console.WriteLine("Digite o numero de voltas: ");
        numeroVoltas = Int32.Parse(Console.ReadLine());

        int[] tempos = new int[numeroVoltas];
        for(int x = 0; x < numeroVoltas; x++)
        {
            Console.WriteLine("Digite o tempo da " + (x + 1) + "a volta (em segundos): ");
            tempos[x] = Int32.Parse(Console.ReadLine());
            total+= tempos[x];

            if (tempos[x] < melhorTempo || x == 0)
            {
                melhorTempo= tempos[x];
                melhorVolta = x + 1;
            }
        }

        media = total/numeroVoltas;

        Console.WriteLine("i.   O melhor tempo foi: " + melhorTempo + " segundos.");
        Console.WriteLine("ii.  Melhor volta foi a " + melhorVolta + "ª.");
        Console.WriteLine("iii. A média de tempo foi: " + media);
    }
}