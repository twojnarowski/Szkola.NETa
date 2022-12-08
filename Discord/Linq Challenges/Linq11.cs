/*LINQ Challange #11
❤️ Piąteczek, piątunio ❤️ 
Ładna pogoda się za oknem robi, więc szybko na liczbach coś policzymy i... weekend 😎 ☀️ 🍹 

Na początek mamy podaną tablicę liczb całkowitych oraz liczbę m.
Musimy obliczyć iloczyn największych m elementów tablicy.

Przykład:
var array = new int[] {3, 2, 8, 9, 7};
var m = 3;

Oczekiwany rezultat:
504 => 9 * 8 * 7 = 504

Założenia:
1. Tablica składa się z co najmniej 3 elementów.
2. Elementy tablicy mogą być dodatnie, ujemne lub równe zero.
3. Elementy w tablicy mogą się powtarzać.

Przykład:
var array = new int[] {-4, -3, 7, -2, -4, -3};
var m = 2;

Wynik:
-14 => 7 * -2 = -14

Szablon do uzupełnienia:*/

private static int MaxProduct(int[] array, int size)
    {
        return array.OrderByDescending(x => x).Take(size).Aggregate(1, (x, y) => x * y);
    }


/* Enjoy 🙂 */
