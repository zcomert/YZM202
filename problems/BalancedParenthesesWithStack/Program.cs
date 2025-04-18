Console.Write("Girdiyi girin.\n->");

var input = Console.ReadLine();

if (input is null) return;

Console.WriteLine($"Girdi: {input}\nDenge Durumu: {BalancedParenthesesWithStack.BalancedBracketChecker.CheckBalanced(input)}");

namespace BalancedParenthesesWithStack
{
    public static class BalancedBracketChecker
    {
        public static bool CheckBalanced(string input)
        {
            var openChars = new List<char>() { '(', '{', '[' };
            var pair = new Dictionary<char, char>() { { '(', ')' }, { '{', '}' }, { '[', ']' } };
            var stack = new DataStructures.Stack.Stack<char>();

            foreach (var currentChar in input)
            {
                if (openChars.Contains(currentChar))
                    stack.Push(currentChar);
                else
                {
                    if (stack.Count == 0)
                        return false;
                    else if (pair[stack.Peek()] == currentChar)
                        stack.Pop();
                    else
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
