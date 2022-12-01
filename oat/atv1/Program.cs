    class Program{
        static void Main(String[] args){
            
            Console.WriteLine("Digite o valor de A");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C");
            int c = Int32.Parse(Console.ReadLine());

            int sum = a + b;
            if(sum > c){
                Console.WriteLine("A soma de a+b é maior que C");
            } else{
                Console.WriteLine("A soma de a+b é menor que C");
            }

        }
    }