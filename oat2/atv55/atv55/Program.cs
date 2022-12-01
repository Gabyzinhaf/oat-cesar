using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        string frase;
        string novaFrase = " ";
        int cont = 0;

        do
        {
            Console.WriteLine("Digite sua frase (ate 50 caracteres): ");
            frase = Console.ReadLine();
        } while (frase.Length > 50);

        char[] ArrayChars = frase.ToCharArray();

        for(int i=0; i < ArrayChars.Length; i++)
        {
            if (ArrayChars[i]!=' ')
            {
                novaFrase = novaFrase + ArrayChars[i];
            }

            if (ArrayChars[i] == ' ')
            {
                cont++;
            }
        }

        Console.WriteLine("Nova frase:" + novaFrase);
        Console.WriteLine("Quantidade de espaco em branco: " + cont);

    }
}