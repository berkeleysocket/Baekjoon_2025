using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputSt = Console.ReadLine();

            char[] reverseSt = inputSt.ToCharArray();

            Array.Reverse(reverseSt);

            if(new string (reverseSt) == inputSt)
            {
                Console.WriteLine('1');
            }
            else
            {
                Console.WriteLine('0');
            }
        }
    }
}
