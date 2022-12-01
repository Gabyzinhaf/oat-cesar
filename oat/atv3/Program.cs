namespace ConsoleApp{
    class Program{
        static void Main(String[] args){
            double a;
            
            Console.WriteLine("Digite o numero: ");
            a = double.Parse(Console.ReadLine());

            if(a % 2 == 0){
                Console.WriteLine("O numero é par");
            } else {
                Console.WriteLine("O numero é impar");
            }
        }
    }
}