namespace Algorytm22;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[] { 5, 100, 4, 200, 1, 3, 3, 2, 99, 98, 101, 102, 103, 104, 105, 106, 107, 109, 110, 108, 108, 110, 111, 112, 113, -1, -2, 0, -3, -4, 6, 7 };
        int k = 104;
        FindSum(array, k);
    }

    public static (bool Found, int, int) FindSum(int[] array, int k)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == k)
                {
                    Console.WriteLine($"Found: {array[i]} {array[j]}");
                    return (Found: true, array[i], array[j]);
                }
            }
        }
        return (Found: false, 0, 0);
    }
}