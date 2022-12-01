class Program{
    static void Main(String[] args){

        Console.WriteLine("Digite o numero: ");
        int numero = Int32.Parse(Console.ReadLine());
        int maior = numero;
        int menor = numero;

        while(numero > 0){
            Console.WriteLine("Digite o numero: ");
            numero = Int32.Parse(Console.ReadLine());
            if(numero > maior){
                maior = numero;
            } else if(numero < menor){
                menor = numero;
            } else if (numero < 0){
                break;
            }
        }
        Console.WriteLine("Maior número: " + maior);
        Console.WriteLine("Menor número: " + menor);
                
    }
}