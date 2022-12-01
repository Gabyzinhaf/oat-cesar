class Program{
    static void Main(String[] args){
        string linha;
        int nota;
        int soma = 0;
        int conta = 0;
        int media;

        while (conta < 25)
        {
            conta = conta + 1;
            Console.Write("Introduza a nota do teste do aluno " + conta + ": ");
            linha = Console.ReadLine();
            nota = Int32.Parse(linha);
            soma = soma + nota;
        }
        media = soma / conta;
        Console.WriteLine("Soma= " + soma + " Media= " + media + " conta " + conta);

    }
}