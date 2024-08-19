namespace MathGame.JKnuds1
{
    internal class GameEngine
    {
        internal void AdditionGame(int numberOfLevels)
        {

            Random random = new Random();
            int score = 0;
            for (int i = 0; i < numberOfLevels; i++)
            {
                int firstNumber = random.Next(1, 10);
                int secondNumber = random.Next(1, 10);
                int sum = firstNumber + secondNumber;

                Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
                string? answer = Console.ReadLine();
                int answerNumber;

                if (int.TryParse(answer, out answerNumber))
                {
                    if (answerNumber == sum)
                    {
                        Console.WriteLine("Correct Answer!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong! Answer was {sum}.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
            Console.WriteLine($"Your Score was {score}/{numberOfLevels}");
            Helpers.AddHistory(score, numberOfLevels, "Addition");

        }

        internal void SubtractionGame(int numberOfLevels)
        {
            Random random = new Random();
            int score = 0;
            for (int i = 0; i < numberOfLevels; i++)
            {
                int firstNumber = random.Next(1, 10);
                int secondNumber = random.Next(1, 10);
                int sum = firstNumber - secondNumber;

                Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
                string? answer = Console.ReadLine();
                int answerNumber;

                if (int.TryParse(answer, out answerNumber))
                {
                    if (answerNumber == sum)
                    {
                        Console.WriteLine("Correct Answer!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong! Answer was {sum}.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
            Console.WriteLine($"Your Score was {score}/{numberOfLevels}.");
            Helpers.AddHistory(score, numberOfLevels, "Subtraction");
        }

        internal void MultiplicationGame(int numberOfLevels)
        {
            Random random = new Random();
            int score = 0;

            for (int i = 0; i < numberOfLevels; i++)
            {
                int firstNumber = random.Next(1, 10);
                int secondNumber = random.Next(1, 10);
                int sum = firstNumber * secondNumber;

                Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
                string? answer = Console.ReadLine();
                int answerNumber;

                if (int.TryParse(answer, out answerNumber))
                {
                    if (answerNumber == sum)
                    {
                        Console.WriteLine("Correct Answer!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong! Answer was {sum}.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
            Console.WriteLine($"Your score was {score}/{numberOfLevels}.");
            Helpers.AddHistory(score, numberOfLevels, "Multiplication");
        }

        internal void DivisionGame(int numberOfLevels)
        {
            Random random = new Random();
            int score = 0;

            for (int i = 0; i < numberOfLevels; i++)
            {
                List<int> numbers = Helpers.GetNumbers();
                int firstNumber = numbers[0];
                int secondNumber = numbers[1];
                int sum = firstNumber / secondNumber;

                Console.WriteLine($"{firstNumber} / {secondNumber} = ?");
                string? answer = Console.ReadLine();
                int answerNumber;

                if (int.TryParse(answer, out answerNumber))
                {
                    if (answerNumber == sum)
                    {
                        Console.WriteLine("Correct Answer!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong! Answer was {sum}.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
            Console.WriteLine($"Your score was {score}/{numberOfLevels}");
            Helpers.AddHistory(score, numberOfLevels, "Division");
        }
    }
}