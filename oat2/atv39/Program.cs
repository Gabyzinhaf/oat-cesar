class Program{
    static void Main(String[] args){
        string opt = "S";
            while (opt == "S")
            {
                
                if(opt == "S"){
                Console.WriteLine("Digite o Número: ");
                int a = Int32.Parse(Console.ReadLine());

                if(a > 0){
                    Console.WriteLine("O numero é positivo");
                } else if(a < 0){
                    Console.WriteLine("O numero é negativo");
                }

                if(a % 2 == 0){
                    Console.WriteLine("O numero é par");
                } else {
                    Console.WriteLine("O numero é impar");
                }
            }
                Console.WriteLine("Deseja encerrar o programa? S");
                opt = Console.ReadLine();
            }
        
    }
}