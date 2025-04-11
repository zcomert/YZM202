string Conversion(int number, int nBase)
{
    var conTable = "0123456789ABCDEF";
    string result = "";
    var stack = new DataStructures.Stack.ArrayStack<string>();
    while (number > 0)
    {
        var over = number % nBase;
        stack.Push(conTable[over].ToString());
        number /= nBase;
    }
    while (stack.Count != 0)
    {
        result += stack.Pop();
    }

    return result;
}

Console.WriteLine(Conversion(156, 16));

Console.ReadKey();
