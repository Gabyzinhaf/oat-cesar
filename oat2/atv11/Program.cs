class Program{
    static void Main(String[] args){

        Console.WriteLine("Digite o valor de A: ");
        int a = Int32.Parse(Console.ReadLine());
        int c = a;

        Console.WriteLine("Digite o valor de B: ");
        int b = Int32.Parse(Console.ReadLine());
        a = b;
        b = c;


        Console.WriteLine("Valor da variavel A: " + a);
        Console.WriteLine("Valor da variável B: " + b);



    }
}