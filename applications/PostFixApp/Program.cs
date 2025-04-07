using System;

class Program
{
    static void Main()
    {
        string postfixExpression = "23*54*+9-";
        int result = PostFixExample.EvaluatePostfix(postfixExpression);
        Console.WriteLine($"Postfix Evaluation Result: {result}");
    }
}
