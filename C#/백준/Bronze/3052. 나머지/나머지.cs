using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int resultValue = 10;

            for (int h = 0; h < 10; h++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                numbers.Add(inputNum % 42);
            }

            HashSet<int> resultArr = new HashSet<int>(numbers);

            Console.WriteLine(resultArr.Count);
        }
    }
}
