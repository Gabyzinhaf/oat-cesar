class Program{
    static void Main(String[] args){

        Console.WriteLine("Insira o Raio:");
        double raio = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira a altura: ");
        double altura = double.Parse(Console.ReadLine());

        double volume = 3.14159 * raio * raio * altura;

        Console.WriteLine("Volume de uma lata de óleo: {0:0,0}", volume + "L");
        
    }
}