class Program
{
    static void Main(string[] args)
    {
        int nComponentes;

        Console.WriteLine("Digite o numero de posicoes: ");
        nComponentes = Int32.Parse(Console.ReadLine());

        int[] v1 = new int[nComponentes];
        int[] v2 = new int[nComponentes];

        for(int x=0; x < nComponentes; x++)
        {
            Console.WriteLine("Digite um valor para a posição " + (x + 1) + " do vetor 1: ");
            v1[x] = Int32.Parse(Console.ReadLine());
        }
        for (int x = 0; x < nComponentes; x++)
        {
            Console.WriteLine("Digite um valor para a posição " + (x + 1) + " do vetor 2: ");
            v2[x] = Int32.Parse(Console.ReadLine());
        }

        for(int x=0; x < nComponentes; x++)
        {
            if (v1[x] == v2[x])
            {
                Console.WriteLine("Valores das Posicoes" + (x + 1) + " dos vetores eh igual");
            }
        }
    }
}