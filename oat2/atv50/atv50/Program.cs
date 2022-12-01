class Program
{
    static void Main(string[] args)
    {
        Random gerador = new Random();
        Boolean acertou = false;

        int chute, tentativas = 0;
        
        int numero = gerador.Next(101);

        while(acertou == false)
        {
            Console.WriteLine("Digite um numero de 0 a 100");
            chute = Int32.Parse(Console.ReadLine());
            tentativas++;

            if(chute == numero)
            {
                Console.WriteLine("Voce acertou em " + tentativas + " tentativas!");
                acertou = true;
            }
            else if (chute > numero)
            {
                Console.WriteLine("O numero eh menor.");
            }
            else
            {
                Console.WriteLine("O numero eh maior");
            }
        }
    }
}