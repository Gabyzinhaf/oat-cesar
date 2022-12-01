class Program
{
    static void Main(string[] args)
    {
        int numeroCandidatas = 5;
        int quantidade_aptas = 0;

        string[] nome = new string[5];
        int[] idade = new int[5];


        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Digite o nome da " + (x + 1) + "a candidata");
            nome[x] = Console.ReadLine();

            Console.WriteLine("Digite a idade da "+(x+1)+"a candidata");
            idade[x] = Int32.Parse(Console.ReadLine());

            if (idade[x] >= 18 && idade[x]<21){
                quantidade_aptas++;
            }   
        }

        string[] nome_aptas = new string[quantidade_aptas];
        int[] idade_aptas = new int[quantidade_aptas];

        int y = 0;
        for(int x=0; x < 5; x++)
        {
            if (idade[x] >= 18 && idade[x] < 21)
            {
                nome_aptas[y] = nome[x];
                idade_aptas[y] = idade[x];
                y++;
            }
        }
        Console.WriteLine();

        for(int x = 0; x < quantidade_aptas; x++)
        {
            Console.WriteLine("Nomes Aptos: " + nome_aptas[x] + "\n Idade:" + idade_aptas[x]);
        }
    }
    

}