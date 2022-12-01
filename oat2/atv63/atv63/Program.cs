class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        int numero = Int32.Parse(Console.ReadLine());   

        Console.WriteLine(Verifica(numero));
    }

    public static string Verifica(int numero)
    {
        if (numero % 2 == 0) return "Par";
        else return "Impar";
    }
}