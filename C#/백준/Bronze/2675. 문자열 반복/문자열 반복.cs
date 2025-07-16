using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int repetitionNum = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < repetitionNum; i++)
            {
                string[] inputValues = Console.ReadLine().Split();
                for(int j = 0; j < inputValues[1].Length; j++) 
                {
                    for(int l = 0; l < int.Parse(inputValues[0]); l++)
                    {
                        sb.Append(inputValues[1][j].ToString());  
                    }
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}