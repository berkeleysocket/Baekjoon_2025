namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] words = Console.ReadLine().ToCharArray();
            int resultTime = 0;

            for(int i = 0; i < words.Length; i++)
            {
                switch(words[i])
                {
                    case 'C':
                    case 'B':
                    case 'A':
                        {
                            resultTime += 3;
                            break;
                        }
                    case 'F':
                    case 'E':
                    case 'D':
                        {
                            resultTime += 4;
                            break;
                        }
                    case 'I':
                    case 'H':
                    case 'G':
                        {
                            resultTime += 5;
                            break;
                        }
                    case 'L':
                    case 'K':
                    case 'J':
                        {
                            resultTime += 6;
                            break;
                        }
                    case 'O':
                    case 'N':
                    case 'M':
                        {
                            resultTime += 7;
                            break;
                        }
                    case 'S':
                    case 'R':
                    case 'Q':
                    case 'P':
                        {
                            resultTime += 8;
                            break;
                        }
                    case 'V':
                    case 'U':
                    case 'T':
                        {
                            resultTime += 9;
                            break;
                        }
                    case 'Z':
                    case 'Y':
                    case 'X':
                    case 'W':
                        {
                            resultTime += 10;
                            break;
                        }
                }
            }
            Console.WriteLine(resultTime);
        }
    }
}