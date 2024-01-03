namespace HangmanConsoleApp
{
    internal class Word
    {
        internal string SecretWord { get; set; }
        internal char[] GuessedWord { get; set; }


        internal void InitializeGame()
        {
            string[] words =
            {
                "hangman", "programming", "csharp",
                "developer", "challenge", "animal",
                "snow", "winter", "flower",
            };

            Random random = new Random();
            SecretWord = words[random.Next(words.Length)].ToLower();

            GuessedWord = new char[SecretWord.Length];
            for (int i = 0; i < GuessedWord.Length; i++)
            {
                GuessedWord[i] = '_';
            }
        }
        internal string GetMaskedWord(char[] GuessedWord)
        {
            return new string(GuessedWord);
        }

        internal void UpdateGuessedWord(char Guess)
        {
            for (int i = 0; i < SecretWord.Length; i++)
            {
                if (SecretWord[i] == Guess)
                {
                    GuessedWord[i] = Guess;
                }
            }
        }
    }
}
