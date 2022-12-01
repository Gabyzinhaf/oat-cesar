class Program
{
    static void Main(string[] args)
    {
        int IdadeAnos, IdadeMeses, IdadeDias, IdadeTotalDias;

        Console.WriteLine("Calculadora de idade em dias!\n\n");

        Console.WriteLine("Digite os anos: ");
        IdadeAnos = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite os meses: ");
        IdadeMeses = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite os dias: ");
        IdadeDias = Int32.Parse(Console.ReadLine());

        IdadeTotalDias = IdadeAnos * 365 + IdadeMeses * 30 + IdadeDias;
        Console.WriteLine("Idade total em dias = " + IdadeTotalDias + "\n");
    }
}