string line = args[0];
List<string> subsets = new List<string>();
subsets.Add(line);
for(int i = 0; i < line.Length; i++)
{
    string temp = line.Remove(i,1);
    subsets.Add(temp);
    RemoveNext(temp);
}
subsets.Sort((a, b) => a.Length.CompareTo(b.Length));
foreach (string subset in subsets)
{
    Console.WriteLine(subset);
}

void RemoveNext(string line)
{
    for (int i = 0; i < line.Length; i++)
    {
        string temp = line.Remove(i, 1);
        if (temp.Length > 0 && !subsets.Contains(temp))
        {
            subsets.Add(temp);
        }
        RemoveNext(temp);
    }
}