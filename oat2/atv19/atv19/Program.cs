class Program
{
    static void Main(string[] args)
    {
        int A,B,C;

        Console.WriteLine("Verificador de triangulo");

        Console.WriteLine("Digite o lado A= ");
        A = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o lado B= ");
        B = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o lado C= ");
        C = Int32.Parse(Console.ReadLine());

        if (A < B + C && B < A + C && C < A + B)
        { //Verificar se cada lado é menor que a soma dos outros dois lados.
            if (A == B && B == C)
            { //saber de A==B e se B==C, sendo verdade o triângulo é eqüilátero
                Console.WriteLine("O triângulo é Eqüilátero.");
            }
            else if (A == B || A == C || B == C)
            { //Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles
                Console.WriteLine("O triângulo é Isósceles.");
            }
            else
            { //e caso contrário, o triângulo será escaleno
                Console.WriteLine("O triângulo é Escaleno.");
            }
        }
        else
        { //Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência.
            Console.WriteLine("Os lados fornecidos não caracterizam um triângulo");
        }
    }
}