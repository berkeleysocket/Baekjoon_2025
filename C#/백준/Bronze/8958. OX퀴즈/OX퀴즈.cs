namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            string[] stArray = new string[inputNum];

            for(int g = 0; g < inputNum; g++)
            {
                stArray[g] = Console.ReadLine();
            }

            foreach(string element1 in stArray)
            {
                int count1 = 0;
                int count2 = 0;
                foreach(char element2 in element1)
                {
                    if(element2.ToString() == "O")
                    {
                        count2++;
                        count1 += count2;
                    }
                    else
                    {
                        count2 = 0;
                    }
                }
                Console.WriteLine(count1);
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