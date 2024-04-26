using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hello from server!");
            Thread.Sleep(1000);
        }
    }
}