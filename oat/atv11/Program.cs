class Program{
    static void Main(String[] args){
        Console.WriteLine("Digite o preço: ");
        double preco = double.Parse(Console.ReadLine());
        double valFinal;

        Console.WriteLine("Digite a condição de pagamento:");
        Console.WriteLine("1. A vista (Dinheiro/Cheque), com 10% de desconto");
        Console.WriteLine("2. A vista (Cartão de Crédito), com 15% de desconto");
        Console.WriteLine("3. Duas parcelas, sem juros");
        Console.WriteLine("4. Duas parcelas, com 10% de juros");
        Console.WriteLine("0. SAIR");
        int opt = Int32.Parse(Console.ReadLine());

        do
        {
            switch (opt)
            {
                case 1:
                    valFinal = preco - (0.10 * preco);
                    Console.WriteLine("Opção 01: A vista, dinheiro, 10% de desconto");
                    Console.WriteLine("O valor preço final será de: " + valFinal);
                    opt=99;
                    Console.ReadKey();
                break;

                case 2:
                    valFinal = preco - (0.15 * preco);
                    Console.WriteLine("Opção 02: A vista, cartão de credito, 15% de desconto");
                    Console.WriteLine("O valor preço final será de: " + valFinal);
                    opt=99;
                    Console.ReadKey();
                break;

                case 3:
                    valFinal = preco / 2;
                    Console.WriteLine("Opção 03: Parcelado, sem juros");
                    Console.WriteLine("O valor preço final será de duas parcelas de: " + valFinal);
                    opt=99;
                    Console.ReadKey();
                break;

                case 4:
                    valFinal = 2 / (preco + (0.10 * preco));
                    Console.WriteLine("Opção 04: Parcelado, com 10% de juros");
                    Console.WriteLine("O valor preço final será de: " + valFinal);
                    opt=99;
                    Console.ReadKey();
                break;

                case 0:
                opt=99;
                Console.ReadKey();
                break;
                
                default:
                    Console.WriteLine("OPÇÃO INVALIDA");
                    Console.WriteLine("Digite a condição de pagamento:");
                    Console.WriteLine("1. A vista (Dinheiro/Cheque), com 10% de desconto");
                    Console.WriteLine("2. A vista (Cartão de Crédito), com 15% de desconto");
                    Console.WriteLine("3. Duas parcelas, sem juros");
                    Console.WriteLine("4. Duas parcelas, com 10% de juros");
                    Console.WriteLine("0. SAIR");
                    opt = Int32.Parse(Console.ReadLine());
                break;

            }
        } while (opt!=99);


    }
}