String Conversion(int number, int nbase)
{
    string conTable = "0123456789ABCDEF";
    string result = "";
    DataStructures.Stack.Stack<char> stack = new DataStructures.Stack.Stack<char>();
    while (number > 0)
    {
        var over = number % nbase;
        stack.Push(conTable[over]);
        number /= nbase;
    }

    while (stack.Count != 0)
    {
        result += stack.Pop();
    }

    return result;
}

Console.WriteLine(Conversion(156, 2));
Console.WriteLine(Conversion(156, 8));
Console.WriteLine(Conversion(156, 16));