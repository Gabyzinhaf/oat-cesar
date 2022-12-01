class Program{
    static void Main(String[] args){
        int a,b,c;

        Console.WriteLine("Digite o primerio valor: ");
        a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        b = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor: ");
        c = Int32.Parse(Console.ReadLine());

        if(a>b && a>c){
            Console.WriteLine(a);
        } else if(b>a && b>c){
            Console.WriteLine(b);
        } else if(c>b && c>a){
            Console.WriteLine(c);
        }

        if(a>b && a<c){
            Console.WriteLine(a);
        } else if(b>a && b<c){
            Console.WriteLine(b);
        } else if(c>b && c<a){
            Console.WriteLine(c);
        }
        

        if(a<b && a<c){
            Console.WriteLine(a);
        } else if(b<a && b<c){
            Console.WriteLine(b);
        } else if(c<b && c<a){
            Console.WriteLine(c);
        }
      

    }
}