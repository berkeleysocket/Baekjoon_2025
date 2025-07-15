using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            float[] numbers = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
            float result = 0f;
            float MaxNum = float.MinValue;
            for(int i = 0; i < numberCount; i++)
            {
                if (MaxNum < numbers[i]) MaxNum = numbers[i];
            }

            for (int i = 0; i < numberCount; i++)
            {
                result += numbers[i] / MaxNum * 100;
            }
            Console.WriteLine(result / numberCount);
        }
    }
}