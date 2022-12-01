class Program{
    static void Main(String[] args){
        DateTime dtNascimento = Da;
        DateTime dtAtual;

        dtAtual = DateTime.Now;
        

        Console.WriteLine("Digite o ANO de nascimento: ");
        dtNascimento.AddYears(Int32.Parse(Console.ReadLine()));

        Console.WriteLine("Digite o MES de nascimento: ");
        dtNascimento.AddMonths(Int32.Parse(Console.ReadLine()));

        Console.WriteLine("Digite o DIA de nascimento: ");
        dtNascimento.AddDays(Int32.Parse(Console.ReadLine()));

        Console.WriteLine(dtNascimento);

        int meses = (dtNascimento.Year - dtAtual.Year) * 12;
        int dias = meses * 30;

        Console.WriteLine(dias);


        

    }
}