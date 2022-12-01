namespace ConsoleApp{
    class Program{
        static void Main(String[] args){
            int anosCasamento = 0;

            Console.WriteLine("Dogite seu nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite seu sexo: ");
            Char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu estado civil:");
            String estadoCivil = Console.ReadLine();

            if(sexo == 'F' && estadoCivil == "CASADA"){
                Console.WriteLine("Quantos anos de casamento? ");
                anosCasamento = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Resultados: " + nome + ", " + sexo + ", " + estadoCivil + ", Anos de casamento: " + anosCasamento);
            } else {
                Console.WriteLine("Resultados: " + nome + ", " + sexo + ", " + estadoCivil);
            }

            
        }
    }
}
    