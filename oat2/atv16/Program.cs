class Program{
    static void Main(string[] args){
        Console.WriteLine("Digite o valor A: ");
        int a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor B: ");
        int b = Int32.Parse(Console.ReadLine());

        if(a>b){
            Console.WriteLine("O maior valor é A: " + a);
        } else if(b>a){
            Console.WriteLine("O maior valor é B: " + b);
        } else if(a==b){
            Console.WriteLine("Os valores são iguais! ");
        }
    }
}