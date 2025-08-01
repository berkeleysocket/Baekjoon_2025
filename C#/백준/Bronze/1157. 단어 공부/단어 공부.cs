using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char maxWord = '0';
            int numOfMostUsedChars = 0;
            char[] words = Console.ReadLine().ToUpper().ToCharArray();
            Dictionary<char, int> wordUsageCount = new Dictionary<char, int>();

            foreach (char word in words)
            {
                if (wordUsageCount.ContainsKey(word))
                {
                    wordUsageCount[word] += 1;
                }
                else
                {
                    wordUsageCount.Add(word, 1);
                }
            }

            int maxCount = wordUsageCount.Values.Max();
            foreach (char word in wordUsageCount.Keys)
            {
                if (wordUsageCount[word] == maxCount)
                {
                    maxWord = word;
                    numOfMostUsedChars++;
                }   
            }

            if(numOfMostUsedChars > 1)
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine(maxWord);
            }
        }
    }
}
