namespace HangmanConsoleApp
{
    internal class Hangman
    {
        internal int IncorrectGuesses { get; set; }

        internal Hangman(int incorrectGuesses)
        {
            IncorrectGuesses = incorrectGuesses;
        }

        internal void DrawHangman()
        {
            Console.WriteLine("\n   Hangman");
            Console.WriteLine("\n");

            switch (IncorrectGuesses)
            {
                case 1:
                    Console.WriteLine("   ______");
                    Console.WriteLine("  ||----| ");
                    Console.WriteLine("  ||    |");
                    Console.WriteLine("  ||    O");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||______");
                    Console.WriteLine(" _||_   _||_");
                    break;
                case 2:
                    Console.WriteLine("   ______");
                    Console.WriteLine("  ||----| ");
                    Console.WriteLine("  ||    |");
                    Console.WriteLine("  ||    O");
                    Console.WriteLine("  ||    |");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||______");
                    Console.WriteLine(" _||_   _||_");
                    break;
                case 3:
                    Console.WriteLine("   ______");
                    Console.WriteLine("  ||----| ");
                    Console.WriteLine("  ||    |");
                    Console.WriteLine("  ||    O");
                    Console.WriteLine("  ||   /|");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||______");
                    Console.WriteLine(" _||_   _||_");
                    break;
                case 4:
                    Console.WriteLine("   ______");
                    Console.WriteLine("  ||----| ");
                    Console.WriteLine("  ||    |");
                    Console.WriteLine("  ||    O");
                    Console.WriteLine("  ||   /|\\");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||______");
                    Console.WriteLine(" _||_   _||_");
                    break;
                case 5:
                    Console.WriteLine("   ______");
                    Console.WriteLine("  ||----| ");
                    Console.WriteLine("  ||    |");
                    Console.WriteLine("  ||    O");
                    Console.WriteLine("  ||   /|\\");
                    Console.WriteLine("  ||   /");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||______");
                    Console.WriteLine(" _||_   _||_");
                    break;
                case 6:
                    Console.WriteLine("   ______");
                    Console.WriteLine("  ||----| ");
                    Console.WriteLine("  ||    |");
                    Console.WriteLine("  ||    O");
                    Console.WriteLine("  ||   /|\\");
                    Console.WriteLine("  ||   / \\");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||______");
                    Console.WriteLine(" _||_   _||_");
                    break;
                default:
                    Console.WriteLine("   ______");
                    Console.WriteLine("  ||----| ");
                    Console.WriteLine("  ||    |");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||");
                    Console.WriteLine("  ||______");
                    Console.WriteLine(" _||_   _||_");
                    break;
            }
        }
    }
}
