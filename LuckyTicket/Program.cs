Console.WriteLine ("Hello, say your numbers on ticket");
string ticket = Console.ReadLine ();
Console.WriteLine($"your numbers is {ticket}");
if (ticket.Length < 4)
{
    Console.WriteLine("string < 4");
}
else if (ticket.Length > 8)
{
    Console.WriteLine("string > 8");
}
int x = ticket.Length;

if (x%2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Не четное");
    ticket = "0" + ticket;
    
    
}


