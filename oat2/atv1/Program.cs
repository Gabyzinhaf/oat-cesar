class Program{
    static void Main(String[] args){
        Console.WriteLine("Digite a menor quantidade do estoque:");
        double qtdMin = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a maior quantidade do estoque:");
        double qtdMax = double.Parse(Console.ReadLine());

        double estoqueMedio = (qtdMin + qtdMax) / 2;

        Console.WriteLine("O estoque médio é de: " + estoqueMedio);
        
    }
}