class Program{
    static void Main(String[] args){
        Console.WriteLine("Digite o numero: ");
        int numero = Int32.Parse(Console.ReadLine());
        int maior = numero;
        int menor = numero;
        int media = 0;
        int i;

        for(i = 0;i<=8;i++){
            Console.WriteLine("Digite o numero: ");
            numero = Int32.Parse(Console.ReadLine());
            media = media + numero;
            
            if(numero > 0){
                if(numero > maior){
                    maior = numero;
                } else if(numero < menor){
                    menor = numero;
                } else if (numero < 0){
                    break;
                }
            } else{
                Console.WriteLine("NÚMERO INVÁLIDO!");
            }
                
        }

        Console.WriteLine("Maior número: " + maior);
        Console.WriteLine("Menor número: " + menor);
        Console.WriteLine("Media dos numeros lidos: " + (media / i));
    }
}