class Program{
    static void Main(String[] args){
        Console.WriteLine("Digite o número: ");
        int x = Int32.Parse(Console.ReadLine());
        int a = 0,b = 0;
        if(x > 0){
            a = x;
        } else if(x<0){
            b = x;
        }

        Console.WriteLine("Valor armazenado em A: " + a + " Valor armazenado em B: " + b);
    }
}