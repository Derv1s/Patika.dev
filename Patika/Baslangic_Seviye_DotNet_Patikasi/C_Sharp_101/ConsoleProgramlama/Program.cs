namespace ConsoleProgramlama;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        System.Console.WriteLine("İsminizi girin:");
        string name = Console.ReadLine();

        System.Console.WriteLine("Soyisminizi girin:");
        string surName = Console.ReadLine();

        System.Console.WriteLine("Merhaba " + name + " " + surName);
    }
}
