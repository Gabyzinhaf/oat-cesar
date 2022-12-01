class Program{
    static void Main(String[] args){

        Console.WriteLine("Digite o valor A:");
        int a = Int32.Parse(Console.ReadLine());
        while(a < 0){
            Console.WriteLine("Valor inválido! \n Digite Novamente o valor de A: ");
            a = Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite o valor B:");
        int b = Int32.Parse(Console.ReadLine());
        while(b < 0){
            Console.WriteLine("Valor inválido! \n Digite Novamente o valor de B: ");
            b = Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite o valor C:");
        int c = Int32.Parse(Console.ReadLine());
        while(c < 0){
            Console.WriteLine("Valor inválido! \n Digite Novamente o valor de C: ");
            c = Int32.Parse(Console.ReadLine());
        }

        int maior = 0, menor = 0;
        if(a>b && a>c){
            maior = a;
        } else if(b>a && b>c){
            maior = b;
        } else if(c>b && c>a){
            maior = c;
        }

        if(a<b && a<c){
            menor = a;
        } else if(b<a && b<c){
            menor = b;
        } else if(c<b && c<a){
            menor = c;
        }

       int x = menor * maior;
       int y = maior / menor;

        Console.WriteLine("menor valor multiplicado pelo maior: " + x);
        Console.WriteLine("maior valor divididoo pelo menor: " + y);

        


    }
}