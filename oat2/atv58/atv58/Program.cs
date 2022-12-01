
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de numeros: ");
        int qtd = Int32.Parse(Console.ReadLine());
        double media = 0;

        int[] numeros = new int[qtd];
        for(int i=0; i < qtd; i++)
        {
            Console.WriteLine("Digite o valor " + (i + 1) + ": ");
            numeros[i] = Int32.Parse(Console.ReadLine());
            media += numeros[i];
        }
        media = media / qtd;
        Array.Sort(numeros);

        Console.WriteLine("A media dos valores eh: " + media + "\nO maior valor eh: " + numeros[qtd - 1]);
    }
}