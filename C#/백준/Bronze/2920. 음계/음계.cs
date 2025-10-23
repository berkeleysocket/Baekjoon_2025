using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string input;
            StringBuilder sb = new StringBuilder();

            foreach(string element in inputs)
            {
                sb.Append(element);
            }

            input = sb.ToString();

            if(input == "12345678")
            {
                Console.WriteLine("ascending");
            }
            else if(input == "87654321")
            {
                Console.WriteLine("descending");
            }
            else
            {
                Console.WriteLine("mixed"); 
            }

            //int inputNum = int.Parse(Console.ReadLine());
            //List<int[]> inputArrays = new List<int[]>();

            //for (int g = 0; g < inputNum; g++)
            //{
            //    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //    inputArrays.Add(inputs);
            //}

            //for (int g = 0; g < inputNum; g++)
            //{
            //    int[] inputs = inputArrays[g];
            //    //ACM 호텔

            //    int floorValue = inputs[0];
            //    int roomValue = 0;
            //    int th = inputs[2];

            //    int cal1 = th;
            //    while (cal1 / th > 0)
            //    {
            //        roomValue++;
            //        cal1 -= floorValue;
            //    }

            //    th %= floorValue;
            //    floorValue =  0;

            //    for (int h = 0; h < th; h++)
            //    {
            //        floorValue++;
            //    }

            //    Console.WriteLine(floorValue.ToString() + roomValue.ToString());
            //}
        }
    }
}