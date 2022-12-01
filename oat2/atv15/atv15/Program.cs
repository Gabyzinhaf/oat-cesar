using System;

class Program
{
    static void Main(string[] args)
    {
        double PrimeiraNota = 0, SegundaNota = 0, TerceiraNota = 0, QuartaNota = 0, RecuperacaoNota, Media;
        bool Aprovacao = false;

        Console.Write("Verificador de notas:\n\n ");

        Console.WriteLine("Digite a primeira nota: ");
        PrimeiraNota = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        PrimeiraNota = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota: ");
        PrimeiraNota = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota: ");
        PrimeiraNota = double.Parse(Console.ReadLine());

        Media = (PrimeiraNota + SegundaNota + TerceiraNota + QuartaNota)/4;

        if (Media >= 7) Aprovacao = true;
        else
        {
            Console.WriteLine("O aluno ficou de recuperação, digite a nota: ");
            RecuperacaoNota = double.Parse(Console.ReadLine());
            Media = (Media + RecuperacaoNota) / 2;
            if (Media >= 7) Aprovacao = true;
        }

        if (Aprovacao == true)
        {
            Console.WriteLine("\n\nO Aluno foi aprovado com a média " + Media);
        }
        else
        {
            Console.WriteLine("\n\nO Aluno foi reprovado com a média " + Media);
        }
    }
}