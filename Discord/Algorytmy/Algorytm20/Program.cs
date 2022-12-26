List<int> sortedNumbers = new() { 1, 2, 3, 4, 5 };
List<int> mixedNumbers = new();
int len = sortedNumbers.Count;
for (int i = 0; i < len; i++)
{
    int index;
    if (i % 2 == 0)
    {
        index = 0;
    }
    else
    {
        index = sortedNumbers.Count - 1;
    }

    mixedNumbers.Add(sortedNumbers[index]);
    sortedNumbers.RemoveAt(index);
}

string result = string.Join(", ", mixedNumbers.ToArray());
Console.WriteLine(result);