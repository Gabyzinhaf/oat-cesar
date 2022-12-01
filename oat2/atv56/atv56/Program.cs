class Program
{
    static void Main(string[] args)
    {
        int[] NumeroInteiros = new int[50];
        int qtdParMaiorQue5 = 0, x = 0;

        while (x < 50)
        {
            Console.WriteLine("Digite um numero inteiro para a posicao " + (x + 1) + ": ");
            NumeroInteiros[x] = Int32.Parse(Console.ReadLine());
            if (NumeroInteiros[x] >= 0)
            {
                if (NumeroInteiros[x] % 5 == 0 && NumeroInteiros[x] % 2 == 0)
                {
                    qtdParMaiorQue5++;
                }
                x++;
            }
        }
        Console.WriteLine("A Quantidade de numeros pars e multiplos de 5 eh de: " + qtdParMaiorQue5);
    }
}