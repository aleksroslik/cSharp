using System;

namespace NumberGuesser
{
    // Main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();
            
            while (true)
            {

                //create a new ramdom number

                Random random = new Random();
                int correctNumber = random.Next(1, 11);

                // init guess var

                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10?");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    // make sure it is a number!

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColor(ConsoleColor.Blue, "This is not a number! :(");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColor(ConsoleColor.Red, "Wrong answer! :P");
                    }

                    if (guess == correctNumber)
                    {
                        PrintColor(ConsoleColor.Green, "You are CORRECT! Well done! :)");
                        Console.ResetColor();
                    }

                }

                Console.WriteLine("Do you want to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                    {
                    continue;
                    }
                else if (answer == "N")
                    {
                    return;
                    }
            }

            
        }

        static void GetAppInfo()
        {
            // header with name of application and basic info
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ola Ross";

            //change text color

            Console.ForegroundColor = ConsoleColor.Yellow;

            // app info display
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Let's play a game...");
        }
        static void PrintColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
