/*LINQ Challange #10
Dzisiaj hazardowo 🎰  Zagramy w Pokera 🙂

Do dyspozycji mamy karty:
2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A

* J - Walet
* Q - Dama
* K - Król
* A - As

Do dyspozycji są cztery kolory:
H, S, D, C

* H - serca (hearts)
* S - piki (spades)
* D - karo (diamonds)
* C - clubs (trefle)

Należy sprawdzić, czy dany gracz posiada w ręku kolor (z ang. flush). Kolor, to wszystkie karty w tym samym kolorze 😉 
Naszą ręką będzie tablica stringów, której elementy są złączeniem wartości karty i jej koloru.

Przykład:
var cards1 = new[] {"9H", "3H", "AH", "7H", "QH"}; // => true
var cards2 = new[] {"3S", "3H", "5S", "1oH", "JH"}; // => false

Szablon do uzupełnienia:*/

private static bool CheckIfFlush(string[] input)
{
	return input.DistinctBy(x => x.Last()).Count() == 1;
}

/*Enjoy 🙂*/
