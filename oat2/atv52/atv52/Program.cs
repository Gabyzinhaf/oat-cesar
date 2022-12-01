class Program
{
    static void Main(string[] args)
    {
        int nPosicoes = 100, x = 0;

        int[] numero = new int[nPosicoes];
        int contar1=0,contar3=0,contar4= 0;

        do
        {
            Console.WriteLine("Digite o proximo numero (Digite -1 para sair): ");
            numero[x] = Int32.Parse(Console.ReadLine());
            if (numero[x] == 1) contar1++;
            if (numero[x] == 3) contar3++;
            if (numero[x] == 4) contar4++;
            x++;
        } while (numero[x - 1] != -1 && x < nPosicoes);

        Console.WriteLine("Quantidades:\nNumero 1 = " + contar1 + "\nNumero 3 = "+contar3+"\nNumero 4 = "+contar4);
    }
}