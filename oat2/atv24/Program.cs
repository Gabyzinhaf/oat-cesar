class Program{
    static void Main(String[] args){
        Console.WriteLine("Digite o primeiro valor: ");
        int a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        int b = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o cód. da Operação: ");
        Console.WriteLine("1. A é multiplo de B?");
        Console.WriteLine("2. Os dois números são pares?");
        Console.WriteLine("3. A média dos dois número é maior ou igual a 7?");
        Console.WriteLine("4. SAIR");
        int opt = Int32.Parse(Console.ReadLine());

        while(opt != 4){
            switch(opt){
                case 1:
                    if(a % b == 0){
                        Console.WriteLine("O primeiro valor é multiplo do segundo valor.");
                    } else if (b % a == 0){
                        Console.WriteLine("O segundo valor é multiplo do primeiro valor.");
                    } else {
                        Console.WriteLine("Os valores não são multiplos");
                    }
                    opt = 0;
                break;

                case 2:
                    if(a % 2 == 0 && b % 2 == 0){
                        Console.WriteLine("Os dois valores são pares");
                    } else {
                        Console.WriteLine("Os dois valores não são pares.");
                    }
                    opt = 0;
                break;

                case 3:
                    int media = (a + b) / 2;
                    if(media>=7){
                        Console.WriteLine("A media dos dois número é maior ou igual a 7");
                    } else{
                        Console.WriteLine("A media dos dois números não é maior ou igual a 7");
                    }
                    opt = 0;
                break;

                case 4:
                    opt = 4;
                break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Digite o cód. da Operação: ");
                    Console.WriteLine("1. A é multiplo de B?");
                    Console.WriteLine("2. Os dois números são pares?");
                    Console.WriteLine("3. A média dos dois número é maior ou igual a 7?");
                    Console.WriteLine("4. SAIR");
                    opt = Int32.Parse(Console.ReadLine());

                break;
            }
        }

    }
}