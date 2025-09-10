using System.Runtime.CompilerServices;

namespace _08.BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Stack<int> roundBrackets = new();
            Stack<int> squareBrackets = new();
            Stack<int> curlyBrackets = new();

            for (int i = 1; i <= input.Length; i++)
            {
                switch (input[i - 1])
                {
                    case '(':
                        roundBrackets.Push(i);
                        break;
                    case '{':
                        curlyBrackets.Push(i);
                        break;
                    case '[':
                        squareBrackets.Push(i);
                        break;
                    default:
                        switch (input[i - 1])
                        {
                            case ')':

                                if (!AreTheParenthesesBalanced(roundBrackets, i))
                                {
                                    return;
                                }

                                break;

                            case '}':
                                if (!AreTheParenthesesBalanced(curlyBrackets, i))
                                {
                                    return;
                                }

                                break;
                            case ']':
                                if (!AreTheParenthesesBalanced(squareBrackets, i))
                                {
                                    return;
                                }

                                break;
                        }
                        break;
                }


            }
            if (roundBrackets.Count == 0 && 
                squareBrackets.Count == 0 && 
                curlyBrackets.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                PrintNo();
            }

        }

        static bool AreTheParenthesesBalanced(Stack<int> OpenIndexes, int closingIndex)
        {
            if ((OpenIndexes.Count > 0) && ((OpenIndexes.Peek() - closingIndex) % 2 != 0))//NotEmpty & Odd
            {
                OpenIndexes.Pop();
                return true;
            }
            else
            {
                PrintNo();
                return false;
            }
        }


        static void PrintNo()
        {
            Console.WriteLine("NO");
        }
    }
}
