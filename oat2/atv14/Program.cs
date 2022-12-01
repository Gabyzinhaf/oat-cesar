class Program{
    static void Main(String[] args){
        Console.WriteLine("Digite o primeiro valor: ");
        int a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        int b = Int32.Parse(Console.ReadLine());

        if(a > b){
            a = a - b;
            Console.WriteLine("A diferença entre o maior valor e o menor é de: " + a);
        } else if(b > a){
            b = b - a;
            Console.WriteLine("A diferença entre o maior valor e o menor é de: " + b);
        }
    }
}