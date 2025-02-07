public class Program
{
    static void Main(string[] args)
    {
        // Exemplos de entrada
        string[] words = { "USA", "FlaG", "leetcode", "Google" };

        foreach (var word in words)
        {
            bool result = DetectCapitalUse(word);
            Console.WriteLine($"Input: {word}");
            Console.WriteLine($"Output: {result}\n");
        }
    }

    public static bool DetectCapitalUse(string word)
    {
        // Verifica se todas as letras são maiúsculas
        if (word.ToUpper() == word)
            return true;

        // Verifica se todas as letras são minúsculas
        if (word.ToLower() == word)
            return true;

        // Verifica se somente a primeira letra é maiúscula
        if (char.IsUpper(word[0]) && word.Substring(1).ToLower() == word.Substring(1))
            return true;

        return false;
    }
}