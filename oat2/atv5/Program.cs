class Program{
    static void Main(String[] args){
        Console.WriteLine("Digite tempo gasto na viagem(h): ");
        double tempoGasto = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a velocidade media: ");
        double velMedia = double.Parse(Console.ReadLine());

        double distancia = tempoGasto * velMedia;
        double litros_usados = distancia / 12;

        Console.WriteLine("Velocidade Media: " + velMedia + "km/h \n"+ "Tempo Gasto: " + tempoGasto + " horas \n" + "Distância:"  + distancia + "km \n" + "Litros usados: " + litros_usados);
    }
}