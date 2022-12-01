class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o Salario atual: ");
        double SalarioAtual = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o percentual de reajuste: ");
        double reajuste = (double.Parse(Console.ReadLine()) / 100);
        Console.WriteLine("O novo salario eh de R$ {0:N}", Reajuste(SalarioAtual, reajuste));

    }

    public static double Reajuste(double Salario, double indiceReajuste)
    {
        double NovoSalario = Salario + (Salario * indiceReajuste);
        return NovoSalario;
    }
}