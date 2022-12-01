class Program{
    static void Main(String[] args){
        Console.WriteLine("Digite o primeiro valor: ");
        int a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        int b = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor: ");
        int c = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o quarto valor: ");
        int d = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Soma A+B: " + (a+b));
        Console.WriteLine("Multiplicação A+B: " + (a*b));
        Console.WriteLine("Soma A+C: " + (a+c));
        Console.WriteLine("Multiplicação A+C: " + (a*c));
        Console.WriteLine("Soma A+D: " + (a+d));
        Console.WriteLine("Multiplicação A+D: " + (a*d));
        Console.WriteLine("Soma B+C: " + (b+c));
        Console.WriteLine("Multiplicação B+C: " + (b*c));
        Console.WriteLine("Soma B+D: " + (b+d));
        Console.WriteLine("Multiplicação B+D: " + (b*d));
        Console.WriteLine("Soma D+C: " + (d+c));
        Console.WriteLine("Multiplicação D+C: " + d*c);
        

    }
}