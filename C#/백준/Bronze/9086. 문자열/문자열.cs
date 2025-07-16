using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < t; i++)
            {
                string inputSt = Console.ReadLine();
                sb.AppendLine($"{inputSt[0]}{inputSt[inputSt.Length - 1]}");
            }

            Console.WriteLine(sb);
        }
    }
}