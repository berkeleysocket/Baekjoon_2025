namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputSt = (Console.ReadLine());
            char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            int[] result = new int[26];
            for(int i = 0; i < alphabets.Length; i++)
            {
                for(int j = 0; j < inputSt.Length; j++)
                {
                    if (alphabets[i] == inputSt[j]) { result[i] = j; break; }
                    result[i] = -1;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}