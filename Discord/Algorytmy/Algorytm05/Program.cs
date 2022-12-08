// Storing words and letter groups.
// Letter group -> all letters forming a word, in alphabetical order.
List<(string letterGroup, string word)> _wordDictionary = new();

foreach (string arg in args)
{
    // Cleaning user input.
    string safeWord = new(arg.ToLower().Where(w => char.IsLetter(w)).ToArray());
    if (safeWord.Length > 0)
    {
        // Saving letter group and word.
        _wordDictionary.Add(new(string.Concat(safeWord.OrderBy(c => c)), safeWord));
    }
}

// Selecting each distinct letter group.
foreach (var letterGroup in _wordDictionary.Select(w => w.letterGroup).OrderBy(w => w).Distinct())
{
    // Selecting each distinct word with given letter group, thus printing out the anagrams or lone words without anagrams.
    foreach (string word in _wordDictionary.Where(w => w.letterGroup == letterGroup).Select(w => w.word).Distinct())
    {
        Console.Write("'{0}' ", word);
    }
    Console.WriteLine();
}