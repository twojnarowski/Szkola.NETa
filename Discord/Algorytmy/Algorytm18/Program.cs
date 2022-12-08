void FindSolution(int eggWillBreakAtOrHigher, int numberOfFloors)
{
    List<int> possibleLevels = Enumerable.Range(0, numberOfFloors).ToList();
    List<(int level, int outcome)> scores = new();
    foreach (int level in possibleLevels)
    {
        scores.Add((level, -1));
    }

    int res = -1;

    while (!IsSolutionFound(scores, out res))
    {
        int guess = possibleLevels.Count / 2;
        int middleFloor = possibleLevels.ElementAt(guess);

        if (middleFloor >= eggWillBreakAtOrHigher)
        {
            scores[middleFloor] = (middleFloor, 1);
            possibleLevels = possibleLevels.Where(x => x < middleFloor).ToList();
        }
        else
        {
            scores[middleFloor] = (middleFloor, 0);
            possibleLevels = possibleLevels.Where(x => x > middleFloor).ToList();
        }
    }
}

bool IsSolutionFound(List<(int level, int outcome)> scores, out int res)
{
    for (int i = 0; i < scores.Count - 1; i++)
    {
        if (scores[i].outcome == 0 && scores[i + 1].outcome == 1)
        {
            res = scores[i + 1].level;
            Console.WriteLine("Egg starts breaking at level: " + res);
            return true;
        }
    }
    res = -1;
    return false;
}

Random rnd = new();

for (int i = 0; i < 100; i++)
{
    var floors = rnd.Next(150) + 3;
    var egg = rnd.Next(1, floors);
    FindSolution(egg, floors);
}

Console.WriteLine("End");