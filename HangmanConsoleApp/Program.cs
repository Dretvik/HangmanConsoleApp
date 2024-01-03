namespace HangmanConsoleApp
{
    internal class Program
    {
        internal Hangman hangman;
        internal Word word;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello, and welcome to Ellie Marie's hangman game!\n");
                Console.WriteLine("1. Start Game \n2. Exit Program");
                Console.WriteLine("\nPlease choose an option...");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunGame();
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, press any key and try again..");
                        Console.ReadLine();
                        break;
                }

            }
            
        }

        internal void RunGame()
        {
            hangman = new Hangman(0);
            word = new Word();
            word.InitializeGame();


            while (hangman.IncorrectGuesses < 6)
            {
                Console.Clear();
                hangman.DrawHangman();
                Console.WriteLine($"\n Guess the Word: {word.GetMaskedWord(word.GuessedWord)}");
                Console.WriteLine($"\n Incorrect Guesses: {hangman.IncorrectGuesses}/6");


                Console.Write(" Enter a letter: ");
                char Guess = Console.ReadLine().ToLower()[0];

                if (!char.IsLetter(Guess))
                {
                    Console.WriteLine("Please enter a valid letter.");
                    continue;
                }

                if (word.SecretWord.Contains(Guess))
                {
                    Console.WriteLine("Good guess!");
                    word.UpdateGuessedWord(Guess);
                }
                else
                {
                    Console.WriteLine("Incorrect guess. Try again!");
                    hangman.IncorrectGuesses++;
                }

                if (word.GetMaskedWord(word.GuessedWord) == word.SecretWord)
                {
                    Console.Clear();
                    hangman.DrawHangman();
                    Console.WriteLine($"\n Congratulations! \n You guessed the word: \"{word.SecretWord}\"");
                    Console.WriteLine($" You had {hangman.IncorrectGuesses} wrong guesses.\n Can you do better, or do you want to try another word?");
                    Console.WriteLine("\n Press any key to go to main menu...");
                    break;
                }
            }

            if (hangman.IncorrectGuesses == 6)
            {
                Console.Clear();
                hangman.DrawHangman();
                Console.WriteLine($"\n Sorry, you ran out of attempts. \n The correct word was: \"{word.SecretWord}\"");
                Console.WriteLine("\n Press any key to go to main menu...");
            }

            Console.ReadLine();
        }
    }
}
