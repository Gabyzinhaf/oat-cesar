class Program{
    static void Main(String[] args){
        double imc = 0;
        Console.WriteLine("Digite a sua altura:");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o seu sexo:");
        char sexo = char.Parse(Console.ReadLine());

        if(sexo == 'M'){
            imc = (72.7 * altura) - 58;
        } else if(sexo == 'F'){
            imc = (62.1 * altura) - 44.7;
        } else {
            Console.WriteLine("Sexo Inválido!");
        }

        Console.WriteLine("O seu IMC é: {0:0.00}", imc);

    }
}