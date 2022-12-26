namespace Algorytm19;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj tekst do sprawdzenia!");
        string inputSentence = Console.ReadLine().ToUpper();
        Console.WriteLine("Podaj wzór do znalezienia!");
        string inputPhrase = Console.ReadLine().ToUpper();
        if (!inputSentence.Contains(inputPhrase))
        {
            Console.WriteLine("Nie znaleziono...");
            return;
        }

        List<int> indices = new();
        while (inputSentence.Contains(inputPhrase))
        {
            int index = inputSentence.IndexOf(inputPhrase);
            indices.Add(index + indices.Count);
            inputSentence = inputSentence.Remove(index, 1);
        }

        Console.WriteLine($"[{string.Join(", ", indices.ToArray())}]");
    }
}