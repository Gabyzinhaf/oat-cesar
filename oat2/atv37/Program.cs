﻿class Program{
    static void Main(String[] args){
        
        
        Console.WriteLine("Digite o cód. da operação: ");
        Console.WriteLine("1- Adição");
        Console.WriteLine("2- Subtração");
        Console.WriteLine("3- Multiplicação ");
        Console.WriteLine("4- Divisão");
        Console.WriteLine("99- Sair.");
        int opt = Int32.Parse(Console.ReadLine());
        string menu;
        while(opt != 99){
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Digite o primeiro valor: ");
                    int a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor: ");
                    int b = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Total da soma: " + (a + b));
                    Console.WriteLine("Deseja voltar ao menu? S/N");
                    menu = Console.ReadLine();
                    if(menu == "S" || menu == "s"){
                        opt = 0;
                    } else {
                        opt = 99;
                    }
                    
                break;

                case 2:
                    Console.WriteLine("Digite o primeiro valor: ");
                    int x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor: ");
                    int y = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Total da subtração: " + (x - y));
                    Console.WriteLine("Deseja voltar ao menu? S/N");
                    menu = Console.ReadLine();
                    if(menu == "S" || menu == "s"){
                        opt = 0;
                    } else {
                        opt = 99;
                    }
                break;

                case 3:
                    Console.WriteLine("Digite o primeiro valor: ");
                    int z = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor: ");
                    int k = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Total da multiplicação: " + (z * k));
                    Console.WriteLine("Deseja voltar ao menu? S/N");
                    menu = Console.ReadLine();
                    if(menu == "S" || menu == "s"){
                        opt = 0;
                    } else {
                        opt = 99;
                    }
                break;

                case 4:
                    Console.WriteLine("Digite o primeiro valor: ");
                    int p = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor: ");
                    int u = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Total da divisão: " + (p / u));
                    Console.WriteLine("Deseja voltar ao menu? S/N");
                    menu = Console.ReadLine();
                    if(menu == "S" || menu == "s"){
                        opt = 0;
                    } else {
                        opt = 99;
                    }
                break;
                
                case 99:
                break;

                default:
                Console.WriteLine("Digite o cód. da operação: ");
                Console.WriteLine("1- Adição");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Multiplicação ");
                Console.WriteLine("4- Divisão");
                Console.WriteLine("99- Sair.");
                opt = Int32.Parse(Console.ReadLine());
                break;
            }
        }
        
    }
}