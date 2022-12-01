class Program{
    static void Main(String[] args){
        Console.WriteLine("Digite um valor: ");
        int a = Int32.Parse(Console.ReadLine());

        if(a >= 0 && a <= 9){
            Console.WriteLine("VALOR VÁLIDO.");
        } else {
            Console.WriteLine("VÁLOR INVÁLIDO.");
        }
    }
}