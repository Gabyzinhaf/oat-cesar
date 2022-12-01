class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tamanho da base:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o tamanho da altura: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("A hipotenusa eh: " + Hipotenusa(b, a));
    }

    public static double Hipotenusa(double Base, double Altura)
    {
        double hipotenusa = (Base * Base) + (Altura * Altura);
        hipotenusa = Math.Sqrt(hipotenusa);
        return hipotenusa;
    }
}