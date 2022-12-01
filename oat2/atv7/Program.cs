class Program{
    static void Main(String[] args){
        Console.WriteLine("Insira a temperatura em Fahrenheit: ");
        double f = double.Parse(Console.ReadLine());

        double c = (f - 32) * 5/9;

        Console.WriteLine("Temperatura em Celsius: {0:0,0}", c);
    }
}