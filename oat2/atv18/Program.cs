class Program{
    static void Main(String[] args){
        Console.WriteLine("Insira o código: ");
        int cod = Int32.Parse(Console.ReadLine());

        if(cod == 1 || cod == 2 || cod == 3){
            switch (cod)
            {
                case 1:
                Console.WriteLine("Um.");
                break;
                case 2:
                Console.WriteLine("Dois.");
                break;
                case 3:
                Console.WriteLine("Três.");
                break;
            }
        } else {
            Console.WriteLine("Código inválido.");
        }
    }
}