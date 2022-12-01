class Program{
    static void Main(String[] args){
        int fator, i, multiplicacao;
            Console.Write("Digite o valor do fator: ");
            fator = int.Parse(Console.ReadLine());
            for (i=1; i<=10; i++)
            {
                Console.WriteLine("PROCESSO " + i);
                multiplicacao=fator*i;
                Console.WriteLine("O valor do multiplicacao: " + multiplicacao);
                Console.WriteLine();
            }
    }
}