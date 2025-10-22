namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            Console.WriteLine(int.Parse(a) + int.Parse(b) - int.Parse(c));
            Console.WriteLine(int.Parse(a+b) - int.Parse(c));
        }
    }
}