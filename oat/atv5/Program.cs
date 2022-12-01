class Program{
        static void Main(String[] args){
            Console.WriteLine("Digite um numero: ");
            int a = Int32.Parse(Console.ReadLine());

            if(a > 0){
                a = a * 2;
                 Console.WriteLine("O valor dobrado: " + a);
            } else{
                a = a * 3;
                 Console.WriteLine("O valor triplicado: " + a);
            }
        }
}
