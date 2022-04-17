do
{
    Console.WriteLine("Hello, say your numbers on ticket");
    string b = Console.ReadLine();
    Console.WriteLine($"your numbers is {b}");
    if (b.Length < 4)
    {
        Console.WriteLine("string < 4");
    }
    else if (b.Length > 8)
    {
        Console.WriteLine("string > 8");
    }
    else
    {
        int x = b.Length;
        if (x != 0)
        {
            b = 0 + b;
        }
        string c = b.Substring(0, b.Length / 2);
        string d = b.Substring(b.Length / 2);
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < c.Length; i++)
        {
            if (char.IsDigit(c[i]))
            {
                sum1 += Convert.ToInt32(c[i].ToString());
            }
            if (char.IsDigit(d[i]))
            {
                sum2 += Convert.ToInt32(d[i].ToString());
            }
        }
        if (sum1 == sum2)
        {
            Console.WriteLine("You have good luck!");
        }
        else
        {
            Console.WriteLine("Good luck another time!");
        }
    }
    Console.WriteLine("Press Esc to get out or press any button to continue");
} while (Console.ReadKey().Key != ConsoleKey.Escape);
