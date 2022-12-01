using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string frase, Vogais = "aeiouAEIOU", stringVogais = "";

        Console.WriteLine("Digite uma frase: ");
        frase = Console.ReadLine();

        char[] ArrayChars = frase.ToCharArray();

        for(int i=0; i < ArrayChars.Length; i++)
        {
            if (Vogais.Contains("" + ArrayChars[i]))
            {
                stringVogais += ArrayChars[i];
            }
        }

        Console.WriteLine("frase somente com as vogais: " + stringVogais);
    }
}