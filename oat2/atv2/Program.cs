class Program{
    static void Main(string[] args){
        Console.WriteLine("Digite a cotação de um dólar em reais:");
        double dolarCot = double.Parse(Console.ReadLine());

        Console.WriteLine("Quantos dólares você quer converter?");
        double dolar = double.Parse(Console.ReadLine());

        double real = dolar * dolarCot;

        Console.WriteLine("Dólar: " + "{0:00,0}", dolarCot + "\n" +" Valor em Reais: " + real);

    }
}