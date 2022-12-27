int n = 15;

bool[,] matrix = new bool[n, n];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = random.Next(0, 100) > 50;
    }
}

/// wordslen > 3
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        bool isWord = false;
        if (matrix[i, j])
        {
            int k = 0;
            while ( i + k < n && matrix[i + k, j])
            {
                k++;
            }
            int l = 0;
            while (j + l < n && matrix[i, j + l])
            {
                l++;
            }
            if (k > 2 || l > 2)
            {
                Console.WriteLine($"{i} {j} is in a word");
                isWord = true;
            }
        }
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j])
        {
            Console.Write("[ ]");
        }
        else
        {
            Console.Write("   ");
        }
    }
    Console.WriteLine();
}