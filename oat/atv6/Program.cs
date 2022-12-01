class Program{
    static void Main(String[] args){
        bool a;
        bool b;

        Console.WriteLine("Digite se o primeiro é verdadeiro/falso");
        String p = Console.ReadLine();
        if(p == "verdadeiro"){
            a = true;
        } else {
            a = false;
        }

        Console.WriteLine("Digite se o segundo é verdadeiro/falso");
        p = Console.ReadLine();
        if(p == "falso"){
            b = false;
        } else {
            b = true;    
        }

        if(a == true && b == true){
            Console.WriteLine("Os dois valores são verdeiros");
        } else if(a == false && b == false){
            Console.WriteLine("Os dois valores são falsos");
        } else {
            Console.WriteLine("Um é falso e o outro é verdadeiro");
        }
    }
}