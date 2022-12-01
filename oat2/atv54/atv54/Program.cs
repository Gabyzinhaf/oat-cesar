class Program
{
    static void Main(string[] args)
    {
        int[] A = new int[5], B = new int[8];
        List<int> C = new List<int>();
        int w = 0;

        for(int x=0; x < 5; x++)
        {
            Console.WriteLine("Digite um numero para o vetor A:");
            A[x] = Int32.Parse(Console.ReadLine());

        }
        for(int x=0; x < 8; x++)
        {
            Console.WriteLine("Digite um numero para o vetor B: ");
            B[x] = Int32.Parse(Console.ReadLine());
            for(int y=0; y<5;y++)
            {
                if (B[x] == A[y])
                {
                    C.Add(B[x]);
                }
            }  
        }
        Console.WriteLine("Numeros Comuns: ");
        foreach(int numero in C)
        {
            Console.WriteLine(numero);
        }
    }
}