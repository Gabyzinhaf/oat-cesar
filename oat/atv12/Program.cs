class Program{
    static void Main(String[] args){
        int id;
        double va1,va2,va3,me;

        Console.WriteLine("Digite o Nº do Aluno:");
        id = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota da VA1:");
        va1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota da VA2:");
        va2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota da VA3:");
        va3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a Média dos Exercicios:");
        me = double.Parse(Console.ReadLine());

        double ma = (va1 + (va2 * 2) + (va3 * 3) + me) / 7;

        Console.WriteLine("N. do aluno:" + id + ", " + " VA1:" + va1 + " VA2:" + va2 + " VA3:" + va3 + " Media Exercicios: " + me);
        
        if(ma > 90){
            Console.WriteLine("Media de aproveitamento: {0:N2}", Math.Round(ma,2) + " Conceito: A");
            Console.WriteLine("AROVADO!");
        } else if(ma>=75 && ma<90){
            Console.WriteLine("Media de aproveitamento: {0:N2}", Math.Round(ma,2) + " Conceito: B");
            Console.WriteLine("AROVADO!");
        }else if(ma>=60 && ma<75){
            Console.WriteLine("Media de aproveitamento: {0:N2}", Math.Round(ma,2) + " Conceito: C");
            Console.WriteLine("AROVADO!");
        }else if(ma>=40 && ma<60){
            Console.WriteLine("Media de aproveitamento: {0:N2}", Math.Round(ma,2) + " Conceito: D");
            Console.WriteLine("REPROVADO!");
        }else if(ma<40){
            Console.WriteLine("Media de aproveitamento: {0:N2}", Math.Round(ma,2) + " Conceito: E");
            Console.WriteLine("REPROVADO!");
        }


    }
}