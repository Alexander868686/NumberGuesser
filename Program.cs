using System;

namespace NumberGuesser
{
    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("___________________________________________");
            Console.WriteLine("Greetings. I am the amazing Number Guesser.");
            Console.WriteLine("___________________________________________");
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            DisplayGreeting();
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 1024;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(1, 1025);
                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to0 high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low");
                    }
                    guesses++;

                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("WINNER");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing I guess");


            Console.ReadKey();



        }
    }
}
