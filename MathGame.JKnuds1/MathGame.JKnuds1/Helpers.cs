namespace MathGame.JKnuds1
{
    internal class Helpers
    {
        static List<string> history = new();
        internal static List<int> GetNumbers()
        {
            Random random = new();

            List<int> numbers = new();
            int firstNumber = random.Next(1, 100);
            int secondNumber = random.Next(2, 100);

            while (firstNumber % secondNumber != 0 || firstNumber == secondNumber)
            {
                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(2, 100);
            }
            numbers.Add(firstNumber);
            numbers.Add(secondNumber);
            return numbers;
        }

        internal static void DisplayHistory()
        {
            foreach (string game in history)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
        }
        internal static void AddHistory(int gameScore, int maxScore, string gameType)
        {
            history.Add($"{DateTime.Now} - {gameType} - {gameScore}/{maxScore} ");
        }

        internal static int NumberOfProplems()
        {
            bool tryConvert = true;
            int number;
            do
            {
                Console.WriteLine("Insert how many problems to solve");
                string? userInput = Console.ReadLine();

                tryConvert = int.TryParse(userInput, out number);
                if (!tryConvert)
                {
                    Console.WriteLine("Not valid input try again");
                }

            } while (!tryConvert);
            return number;
        }
    }
}