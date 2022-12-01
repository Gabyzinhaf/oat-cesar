class Program{
    static void Main(string[] args){
        Console.WriteLine("Digite o Id do vendedor: ");
        int id = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o código da peça: ");
        int pecaID = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Valor unitário da peça: ");
        double precoPeca = double.Parse(Console.ReadLine());

        Console.WriteLine("Quantidade de peças");
        double qtdPeca = double.Parse(Console.ReadLine());


        double comissao = (precoPeca * qtdPeca) * 0.05;
        double vTotal = precoPeca * qtdPeca;

        Console.WriteLine("Comissão do vendedor '" + id +"': {0:00,0}", comissao);
        Console.WriteLine("Valor total da venda: " + vTotal);
        Console.WriteLine("Código da peça:" + pecaID + "\n" + "Quantidade vendida: " + qtdPeca + "\n" + "Preço Unitário: " +precoPeca);

    }
}