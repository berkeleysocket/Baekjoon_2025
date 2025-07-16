namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputSt = (Console.ReadLine().Trim());
            if (string.IsNullOrWhiteSpace(inputSt)) {Console.WriteLine("0"); return; }
            Console.WriteLine(inputSt.Split().Length);
        }
    }
}