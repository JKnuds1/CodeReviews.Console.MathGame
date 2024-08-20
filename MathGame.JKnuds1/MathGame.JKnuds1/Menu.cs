namespace MathGame.JKnuds1
{
    internal class Menu
    {
        internal void Main(string name)
        {
            GameEngine gameEngine = new();
            bool gameRunning = true;
            int numberOfLevels = 5;

            while (gameRunning)
            {
                Console.Clear();
                Console.WriteLine($@"Welcome {name}. Choose one of the options below:
                                    a - Addition Game.
                                    s - Subtraction Game.
                                    m - Multiplication Game.
                                    d - Division Game.
                                    v - View Game History.
                                    n - Change Number Of Questions.
                                    q - Quit.");

                string? menuChoice = Console.ReadLine();
                while(menuChoice == null) 
                {
                    Console.WriteLine("Wrong Input try again.");
                    menuChoice = Console.ReadLine();
                        }

                switch (menuChoice.ToLower().Trim())
                {
                    case "a":
                        Console.Clear();
                        Console.WriteLine("Addition game selected.");
                        gameEngine.AdditionGame(numberOfLevels);
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        break;

                    case "s":
                        Console.Clear();
                        Console.WriteLine("Subtraction game selected.");
                        gameEngine.SubtractionGame(numberOfLevels);
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        break;

                    case "m":
                        Console.Clear();
                        Console.WriteLine("Multiplication game selected.");
                        gameEngine.MultiplicationGame(numberOfLevels);
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        break;

                    case "d":
                        Console.Clear();
                        Console.WriteLine("Division game selected.");
                        gameEngine.DivisionGame(numberOfLevels);
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        break;

                    case "v":
                        Console.Clear();
                        Console.WriteLine("--------- View History -----------");
                        Helpers.DisplayHistory();
                        break;

                    case "q":
                        Console.WriteLine("Exiting game...");
                        gameRunning = false;
                        break;
                    case "n":
                        Console.Clear();
                        numberOfLevels = Helpers.NumberOfProplems();
                        Console.WriteLine($"You chose {numberOfLevels}.");
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Wrong input.");
                        break;

                }

            }
        }
    }
}
