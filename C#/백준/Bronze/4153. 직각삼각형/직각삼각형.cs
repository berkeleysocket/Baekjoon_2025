namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if (inputs.SequenceEqual(new int[] { 0,0,0 })) break;

                Array.Sort(inputs);

                int a = inputs[0];
                int b = inputs[1];
                int c = inputs[2];

                int aa = a * a;
                int bb = b * b;
                int cc = c * c;

                if(aa + bb == cc)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }
        }
    }
}
