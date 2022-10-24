/*LINQ Challange #9
Piątkowo na mięciutko 🙃  Poćwiczymy jeszcze trochę ostatnią funkcjonalność 😉

Mamy stringa jak poniżej:
var input = "Szkoła Dotneta";

Zadanie polega na tym by zwrócić listę wszystkich znaków wraz z numerem ich pozycji, na której się w tym stringu znajdują.
Nie mylcie pozycji z indeksem ;)

Pożądany rezultat:
["1: S", "2: z", "3: k", "4: o", "5: ł", "6: a", "7:  ", "8: D", "9: o", "10: t", "11: n", "12: e", "13: t", "14: a"]

Szablon do uzupełnienia:*/

private static List<string> PositionOfChars(string input)
{
    return input.Select((x, i) => $"{i+1}: {x}");
}

/*Enjoy 🙂 */
