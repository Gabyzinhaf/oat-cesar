class Program
{
    static void Main(string[] args)
    {
        int numero, maior, menor;

        Console.WriteLine("Digite um número: ");
        numero = Int32.Parse(Console.ReadLine());
        menor = numero;
        maior = numero;

        do
        {
            Console.WriteLine("Digite outro número: ");
            numero = Int32.Parse(Console.ReadLine());

            if (numero > maior) maior = numero;
            if (numero < menor && numero != 0) menor = numero;

        } while (numero != 0);

        Console.WriteLine("\nO menor número é " + menor + " e o maior número é " + maior + ".");
    }
}