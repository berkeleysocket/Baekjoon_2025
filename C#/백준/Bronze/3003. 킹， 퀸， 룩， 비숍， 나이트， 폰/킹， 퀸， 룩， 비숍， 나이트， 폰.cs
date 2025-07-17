using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] chessPiece = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] result = new int[chessPiece.Length];
            for(int i = 0; i < chessPiece.Length; i++)
            {
                if(i < 2)
                {
                    result[i] = 1 - chessPiece[i];
                    continue;
                }
                if(i < chessPiece.Length - 1)
                {
                    result[i] = 2 - chessPiece[i];
                    continue;
                }
                result[i] = 8 - chessPiece[i];
                continue;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}