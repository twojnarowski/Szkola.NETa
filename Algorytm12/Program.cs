using Algorytm12;

List<CoinStorage> coinStorage = new() { new(1, 2), new(2, 2), new(5, 2), new(10, 2), new(20, 2), new(50, 2), new(100, 2), new(200, 2), new(500, 2) };

Console.Write("Podaj kwotę do wydania: ");
string input = Console.ReadLine();
while (input != null && !input.Contains(','))
{
    Console.WriteLine("Błednie podana kwota;");
    Console.Write("Podaj kwotę do wydania: ");
    input = Console.ReadLine();
}
int changeAmount = int.Parse(input.Where(x => char.IsDigit(x)).ToArray());
int totalCoins = 0;
foreach (CoinStorage coinStored in coinStorage.OrderByDescending(x => x.CoinValue))
{
    int coinCounter = 0;
    while (coinStored.CoinValue <= changeAmount && coinStored.CoinsAvailable > 0)
    {
        changeAmount -= coinStored.CoinValue;
        coinStored.CoinsAvailable--;
        coinCounter++;
    }
    if (coinCounter > 0)
    {
        Console.WriteLine($"{(double)coinStored.CoinValue / 100:0.00} zł x {coinCounter}");
        totalCoins += coinCounter;
    }
}
if (changeAmount != 0)
{
    Console.WriteLine($"Zabrakło monet do wydawania! Nie wydano {(double)changeAmount / 100:0.00} zł");
}
else
{
    Console.WriteLine($"Wydanych monet: {totalCoins}.");
}