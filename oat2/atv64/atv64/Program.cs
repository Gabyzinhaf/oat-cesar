class Program
{
    private static int[] Vetor = new int[10];
    static void Main(string[] args)
    {
        bool continuar = true;
        while(continuar)
        {
            Console.WriteLine("1 - Carregar Vetor ");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas os numeros pares do vetor");
            Console.WriteLine("4 - Exibir apenas os numeros impares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de numeros pares existem nas posicoes impares do vetor");
            Console.WriteLine("6 - Exibir a quantaidade de numeros impares existem nas posicoes pares do vetor");
            Console.WriteLine("7 - Sair.");

            Console.WriteLine("Digite uma opcao: ");

            int opcao = Int32.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    CarregarVetor();
                    break;
                case 2:
                    Console.WriteLine(ListarVetor());
                    break;
                case 3:
                    Console.WriteLine(ListarParesVetor());
                    break;
                case 4:
                    Console.WriteLine(ListarImparesVetor());
                    break;
                case 5:
                    Console.WriteLine(QuantidadeParesNosImparesVetor());
                    break;
                case 6:
                    Console.WriteLine(QuantidadeImparesNosParesVetor());
                    break;
                case 7:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Número inválido.");
                    break;
            }
        }
        

    }

    //1 - Carregar Vetor
    public static void CarregarVetor()
    {
        for(int i =0; i < 10; i++)
        {
            Console.WriteLine("Digite o " + (i + 1) + "o numero do Vetor: ");
            Vetor[i] = Int32.Parse(Console.ReadLine());
        }
        Console.WriteLine("Vetor carrregado com sucesso!");
    }

    //2 - Listar Vetor
    public static string ListarVetor()
    {
        string listaVetor = "Valores do vetor: \n";
        for(int i =0; i<10; i++)
        {
            listaVetor += "\t" + Vetor[i] + "\n";
        }
        return listaVetor;
    }

    //3 - Exibir apenas os numeros pares do vetor
    public static string ListarParesVetor()
    {
        string ListaVetor = "Valores do vetor: \n";
        for(int i = 0; i < 10; i++)
        {
            if (Vetor[i] % 2 == 0)
            {
                ListaVetor += "\t" + Vetor[i] + "\n";
            }
        }
        return ListaVetor;
    }

    //4 - Exibir apenas os números ímpares do vetor

    public static string ListarImparesVetor()
    {
        string ListaVetor = "Valores do vetor:\n";
        for (int x = 0; x < 10; x++)
        {
            if (Vetor[x] % 2 == 1)
            {
                ListaVetor += "\t" + Vetor[x] + "\n";
            }
        }
        return ListaVetor;
    }

    //5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor
    public static int QuantidadeParesNosImparesVetor()
    {
        int quantidade = 0;
        for (int x = 1; x < 10; x = x + 2)
        {
            if (Vetor[x] % 2 == 0)
            {
                quantidade++;
            }
        }
        return quantidade;
    }

    //6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor
    public static int QuantidadeImparesNosParesVetor()
    {
        int quantidade = 0;
        for (int x = 0; x < 10; x = x + 2)
        {
            if (Vetor[x] % 2 == 1)
            {
                quantidade++;
            }
        }
        return quantidade;
    }
}