namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStArr = Console.ReadLine().Split();
            char[] st1 = inputStArr[0].ToCharArray(); char[] st2 = inputStArr[1].ToCharArray();
            Array.Reverse(st1); Array.Reverse(st2);
            string reversedSt1 = new string(st1); string reversedSt2 = new string(st2);
            if (int.Parse(reversedSt1) > int.Parse(reversedSt2))
                Console.WriteLine(reversedSt1);
            else
                Console.WriteLine(reversedSt2);
        }
    }
}