class Program{
    static void Main(string[] args){
        int a;
        
        Console.WriteLine("Digite o valor: ");
        a = Int32.Parse(Console.ReadLine());
        if(a % 2 == 0){
            a = a + 5;
        } else {
            a = a + 8;
        }
        Console.WriteLine("Resultado: " + a);
    }
}