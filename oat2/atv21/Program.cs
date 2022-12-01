class Program{
    static void Main(String[] args){

        string chave;
        do
        {
        Console.WriteLine("Digite o valor: ");
        int a = Int32.Parse(Console.ReadLine());

        if(a > 0){
            Console.WriteLine("Esse valor é positivo.");
        } else if(a < 0){
            Console.WriteLine("Esse valor é negativo!");
        }

        Console.WriteLine("Deseja fazer outra operação? S/N");
        chave = Console.ReadLine();
            if(chave == "N" || chave == "n"){
                break;
            } 
        } while (chave != "N" || chave != "n");
        
    }
}