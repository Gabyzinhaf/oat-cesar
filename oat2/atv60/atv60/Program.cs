class Program
{
    static void Main(string[] args)
    {
        int x, y;
        Console.WriteLine("Insira a variavel x: ");
        x= Int32.Parse(Console.ReadLine());
        Console.WriteLine("Insira a variavel y: ");
        y = Int32.Parse(Console.ReadLine());
        Console.WriteLine(VerificaQuadrante(x,y));

    }

    public static int VerificaQuadrante(int x, int y)
    {
        bool quadx, quady;

        if (x >= 0)
        {
            quadx = true;
        }
        else
        {
            quadx = false;
        }
        if (y >= 0)
        {
            quady = true;
        }
        else
        {
            quady = false;
        }

        if (x == 0 || y == 0) return 0;
        else if (quadx && quady) return 1;
        else if (!quadx && quady) return 2;
        else if (!quadx && !quady) return 3;
        else return 4;
    }
}
