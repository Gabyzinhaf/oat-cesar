class Program{
    static void Main(String[] args){
        
        Console.WriteLine("Digite o seu peso:");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura:");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (Math.Pow(altura, 2.0));

        if(imc < 18.5){
            Console.WriteLine("Seu IMC é: {0:00.0}", imc + " Você está Abaixo do peso (<18.5)");
        } else if(imc>18.5 && imc<25){
            Console.WriteLine("Seu IMC é: {0:00.0}", imc + " Você está com peso normal (18.5 ~ 25)");
        } else if(imc>25 && imc<30){
            Console.WriteLine("Seu IMC é: {0:00.0}", imc + " Você está acima do peso (25 ~ 30)");
        } else if(imc>30){
            Console.WriteLine("Seu IMC é: {0:00.0}", imc + " Você está obeso (>30)");
        }
    }
}