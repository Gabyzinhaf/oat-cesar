class Program{
    static void Main(String[] args){
        Console.WriteLine("Insira a temperatura em Celsius");
        double c = double.Parse(Console.ReadLine());

        double f = (9*c+160)/5;

        Console.WriteLine("Temperatura em Fahrenheit: " + f);
    }
}