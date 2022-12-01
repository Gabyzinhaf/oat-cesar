class Program
{
    public static int ChecarCaracter(char ch, char[] alfabeto)
    {
        int numero = 1;
        for (int x = 0; x < alfabeto.Length; x++)
        {
            if (alfabeto[x] == ch)
            {
                numero = x;
            }
        }
        return numero;
    }


    static void Main(string[] args)
    {
        char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'w', 'y', 'z' };

        Console.WriteLine("Digite o primero caractere: ");
        char caracter = char.ToLower(char.Parse(Console.ReadLine()));

        int primeiro_caracter = ChecarCaracter(caracter, alfabeto);

        Console.WriteLine("Digite o segundo caractere: ");
        char outro_caracter = char.ToLower(char.Parse(Console.ReadLine()));

        int segundo_caracter = ChecarCaracter(outro_caracter, alfabeto);

        int diferencas = segundo_caracter - primeiro_caracter - 1;
        if (primeiro_caracter >= 0 && segundo_caracter >= 0 && diferencas >= 0)
        {
            Console.WriteLine("O numero de caracteres entre eles eh: " + diferencas);
        } else
        {
            Console.WriteLine("Erro.");
        }

    }
}