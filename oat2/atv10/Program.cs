class Program{
    static void Main(string[] args){
        Console.WriteLine("Digite o primeiro valor: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        double b = double.Parse(Console.ReadLine());

        if(a == b){
            Console.WriteLine("A é igual B");
        }
        if(a != b){
            Console.WriteLine("A diferente de B");
        }
        if(a > b){
            Console.WriteLine("A é maior que B");
        }
        if(a < b){
            Console.WriteLine("A é menor que B");
        }
        if(a >= b){
            Console.WriteLine("A é maior ou igual que B");
        }
        if(a <= b){
            Console.WriteLine("A é menor ou igual a B");
        }
    }
}