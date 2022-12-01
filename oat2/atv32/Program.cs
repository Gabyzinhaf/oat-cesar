class Program{
    static void Main(String[] args){
        Console.WriteLine("Digite o numero: ");
        double a = double.Parse(Console.ReadLine());
        double b = 0;
        if(a < 10 && a > 0){
            for(double i = 1;i <= 20;i++){
                if(i % 3 == 0){
                    b = Math.Pow((a + i), 2);
                    Console.WriteLine("Soma do Quadrado do número " + i + " é de: " + b);
                }
                
            }
        }
    }
}