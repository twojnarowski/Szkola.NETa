/*LINQ Challange #12
Mam nadzieję, że wypoczęci - wtorek wolny, a dzisiaj piąteczek ❤️ 😉

Nie owijając w bawełnę - mamy listę imion w postaci stringu:
var input = "Hyzio, Dyzio, Zyzio, Donal, Daisy, Sknerus";

Naszym zadanie jest zwrócenie tablicy imion (posortowanej alfabetycznie) wraz z ich numerem porządkowym.

Oczekiwany rezultat:
1. Daisy
2. Donald
3. Dyzio
4. Hyzio
5. Sknerus
6. Zyzio


Szablon do uzupełnienia:*/

private static string[] SortNames(string input)
    {
        return input.Split(", ").ToList().OrderBy(x => x).Select((x,y) => $"{y+1}. {x}").ToArray();
    }

/*Enjoy 🙂 */
