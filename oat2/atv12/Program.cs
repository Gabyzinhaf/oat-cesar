class Program{
    static void Main(String[] args){
        Console.WriteLine("Digite um numero: ");
        double a = double.Parse(Console.ReadLine());

        if(a >= 0){
            Console.WriteLine("O valor do módulo desse número é: " + a);
        } else {
            a = a*(-1);
            Console.WriteLine("O valor do módulo desse número é: " + a);
        }
    }
}