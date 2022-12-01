class Program{
    static void Main(String[] args){
        for(int i = 200;i >= 100; i--){
            if(i % 3 == 0){
                Console.WriteLine("O número " + i + " é impar!");
            }
        }
    }
}