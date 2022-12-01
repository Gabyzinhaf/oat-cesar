class Program
{
    static void Main(string[] args)
    {
        int qtdAlunos, notasBoas = 0;
        Boolean SalaFerrada = true;
        Console.WriteLine("Digite a quantidade de alunos: ");
        qtdAlunos= Int32.Parse(Console.ReadLine());

        int[] notas = new int[qtdAlunos];

        for(int x = 0; x < qtdAlunos; x++)
        {
            Console.WriteLine("Digite a nota do " + (x + 1) + "° Aluno: ");
            notas[x] = Int32.Parse(Console.ReadLine());

            if (notas[x] > 7)
            {
                notasBoas++;
            }
            if (notas[x] > 5) 
            {
                SalaFerrada= false;
            }
        }

        if(SalaFerrada==false)
        {
            Console.WriteLine("Existem " + notasBoas + " notas maiores que 7.");
        }
        else
        {
            Console.WriteLine("nao ha nenhum aluno com nota acima de 5");
        }
    }
}