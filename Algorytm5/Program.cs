List<(string letterGroup, string word)> _wordDictionary = new();
List<string[]> _anagrams = new();

foreach (string givenWord in args)
{
    string safeWord = new(givenWord.ToLower().Where(w => char.IsLetter(w)).ToArray());
    if (safeWord.Length > 0)
    {
        _wordDictionary.Add(new(string.Concat(safeWord.OrderBy(c => c)), safeWord));
    }
}

foreach (var letterGroup in _wordDictionary.GroupBy(w => w.letterGroup).Select(w => w.First().letterGroup).OrderBy(w => w))
{
    List<string> anagrams = new();
    foreach (var word in _wordDictionary.Where(w => w.letterGroup == letterGroup).Select(w => w.word))
    {
        if (!anagrams.Contains(word))
        {
            anagrams.Add(word);
        }
    }
    if (anagrams.Count > 0)
    {
        List<string> anagram = new();
        foreach (string word in anagrams)
        {
            anagram.Add(word);
        }
        _anagrams.Add(anagram.ToArray());
    }
}

if (_anagrams.Count == 0)
{
    Console.WriteLine("''");
}
else
{
    foreach (string[] anagrams in _anagrams)
    {
        foreach (string anagram in anagrams)
        {
            Console.Write("'{0}' ", anagram);
        }
        Console.WriteLine();
    }
}