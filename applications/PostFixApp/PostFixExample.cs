using System;
using System.Collections.Generic;


class PostFixExample
{
    public static int EvaluatePostfix(string expression)
    {
        Stack<int> stack = new Stack<int>();

        foreach (char ch in expression)
        {
            if (char.IsDigit(ch))
            {
                stack.Push(ch - '0'); // Convert char to int
            }
            else
            {
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();

                switch (ch)
                {
                    case '+': stack.Push(operand1 + operand2); break;
                    case '-': stack.Push(operand1 - operand2); break;
                    case '*': stack.Push(operand1 * operand2); break;
                    case '/': stack.Push(operand1 / operand2); break;
                    default: throw new InvalidOperationException("Invalid operator");
                }
            }
        }

        return stack.Pop();
    }
}
