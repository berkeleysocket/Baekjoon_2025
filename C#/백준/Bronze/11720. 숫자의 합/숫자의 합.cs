namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            char[] numbers = Console.ReadLine().ToCharArray();
            int result = 0;
            foreach (char element in numbers)
            {
                if (element != '0')
                    result += int.Parse(element.ToString());
            }
            Console.WriteLine(result);
        }
    }
}