using System.Drawing;
using Newtonsoft.Json;

Console.WriteLine("Podaj wartości RGB koloru: ");
Console.Write("R");
string r = Console.ReadLine();
Console.Write("G");
string g = Console.ReadLine();
Console.Write("B");
string b = Console.ReadLine();
int intR = int.Parse(r.Where(x => char.IsDigit(x)).ToArray());
int intG = int.Parse(g.Where(x => char.IsDigit(x)).ToArray());
int intB = int.Parse(b.Where(x => char.IsDigit(x)).ToArray());

Color color;
try
{
    color = Color.FromArgb(intR, intG, intB);
}
catch (Exception x)
{
    Console.WriteLine("Podano błędne wartości!");
    Environment.Exit(0);
}

color = Color.FromArgb(intR, intG, intB);
string hex = color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
string colorName = "Nieznany";

HttpClient client = new();

string webApiUrl = @"https://www.thecolorapi.com/id?hex=";

HttpResponseMessage response = await client.GetAsync(webApiUrl + hex);
if (response.IsSuccessStatusCode)
{
    string result = await response.Content.ReadAsStringAsync();
    try
    {
        var colorJson = JsonConvert.DeserializeObject<dynamic>(result);
        colorName = colorJson.name.value;
    }
    catch (Exception x)
    {
        Console.WriteLine(x.ToString());
    }
}

Console.WriteLine($"#{hex} ({colorName})");