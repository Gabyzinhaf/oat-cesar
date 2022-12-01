namespace ConsoleApp{
    class Program{
        static void Main(String[] args){
            int c;
            Console.WriteLine("Digite o valor A:");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor B:");
            int b = Int32.Parse(Console.ReadLine());

            if(a == b){
                c = a + b;
            } else{
                c = a * b;
            }
            Console.WriteLine("O valor foi: " + c);            
        }
    }
}