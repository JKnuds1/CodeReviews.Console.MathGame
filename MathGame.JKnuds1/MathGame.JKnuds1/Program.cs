using MathGame.JKnuds1;
Menu Menu = new();


Console.WriteLine("Welcome! Please enter your name:");
string? name = Console.ReadLine();

while (name == null || name == "")
{
    Console.WriteLine("Wrong entry please enter a name:");
    name = Console.ReadLine();
}


Menu.Main(name.ToUpper().Trim());