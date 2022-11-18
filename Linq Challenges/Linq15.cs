/*LINQ Challange #15
Piąteczek moi drodzy ❤️ 😉

Nie wiem, jak Wy, ale ja w pracy lubię sobie słuchać muzyki.
Czy ktoś jest w stanie podać mi całkowity czas trwania poniższej playlisty?

var input = "3:09,5:47,4:23,4:32,4:12,2:43,3:51,4:29,3:24,6:42,3:13,3:14,4:46,5:25,4:52,3:27,4:32,4:12,2:43,7:31:57,4:12,4:43,3:51,4:29,3:24,2:42,3:57";

Oczekiwany rezultat - czas trwania w postaci hh:MM:ss

Szablon do uzupełnienia:*/

private static string TotalDuration(string input)
{
    return Enumerable.Aggregate(input.Split(",").Select(x => x.Length <= 5 ? TimeSpan.Parse(("00:" + x)) : TimeSpan.Parse(x)), new TimeSpan(), (s, d) => s + d);
}

/*Enjoy 🙂*/
