namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> nums = new Dictionary<string,int>();
            for(int g = 0; g < 10; g++)
            {
                nums.Add(g.ToString(), 0);
            }
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());

            string multiply = (input1 * input2 * input3).ToString();

            foreach(char num in multiply)
            {
                nums[num.ToString()] += 1;
            }

            foreach(KeyValuePair<string,int> element in nums)
            {
                Console.WriteLine(element.Value);
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