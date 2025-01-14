namespace cs_hello_world;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Hello, World.");
        Thread.Sleep(1000);
        Console.Write("\n\nWhat is your name? ");
        string username = Console.ReadLine();
        Console.Write($"\nHello, {username}!\n");
    }
}
