int[] array = new int[] { 5, 100, 4, 200, 1, 3, 3, 2, 99, 98, 101, 102, 103, 104, 105, 106, 107, 109, 110, 108, 108, 110, 111, 112, 113, -1, -2, 0, -3, -4, 6, 7 };
var arraySorted = array.Distinct().OrderBy(x => x).ToArray();
int globalMax = 0;
int[] globalMaxArray = new int[0];
int localMax = 1;
int newStart = 0;
for (int current = 1; current < arraySorted.Length; current++)
{
    if (arraySorted[current] - 1 == arraySorted[current - 1])
    {
        localMax++;
    }
    else
    {
        if (localMax > globalMax)
        {
            globalMax = localMax;
            int end = newStart + localMax;
            globalMaxArray = arraySorted[newStart..end];
        }
        localMax = 1;
        newStart = current;
    }
}

Console.WriteLine($"Najdłuższy ciąg ma długość {globalMax} i jest to {string.Join(", ", globalMaxArray)}");