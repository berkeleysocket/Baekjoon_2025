using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initValue = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] numbers = new int[initValue[0]];
            for(int i = 0; i < initValue[0]; i++)
            {
                numbers[i] = i + 1;
            }
            for(int i = 0; i < initValue[1]; i++)
            {
                int[] inputValue = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if(inputValue[0] != inputValue[1])
                {
                    Array.Reverse(numbers, inputValue[0] - 1, inputValue[1] - inputValue[0] + 1);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
