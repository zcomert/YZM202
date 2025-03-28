using TabsLibrary;

var browser = new Browser();

while (true)
{
    try
    {
        Console.WriteLine(
            "1- Add new Tab\n" +
            "2- Remove Tab\n" +
            "3- Get Tab info\n" +
            "4- Next Tab\n" +
            "5- Prev Tab\n" +
            "0- Exit"
            );
        Console.Write("Input: ");
        int index = int.Parse(Console.ReadLine());
        switch (index)
        {
            case 1:
                Console.Write("Input: ");
                var input = Console.ReadLine().Split("-");
                browser.Add(new Tab(
                    int.Parse(input[0]),
                    input[1],
                    input[2],
                    input[3]));
                break;
            case 2:
                browser.Remove();
                break;
            case 3:
                Console.Write("Id Input: ");
                Console.WriteLine(
                    browser.GetTabById(int.Parse(Console.ReadLine()))
                    );
                break;
            
            case 0:
                return;

            default:
                Console.WriteLine("Input incorrect!");
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}