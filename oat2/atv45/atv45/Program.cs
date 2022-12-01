class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de numeros: ");
        int qtd = Int32.Parse(Console.ReadLine());

        int[] numeros = new int[qtd];

        for(int i=0;i<qtd; i++)
        {
            Console.WriteLine("Digite o " + (i+1) +"o numero: ");
            numeros[i] = Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n Ordem Contraria eh: ");
        for(int y=qtd-1;y>=0;y--)
        {
            Console.Write(numeros[y]);
        }
    }
}