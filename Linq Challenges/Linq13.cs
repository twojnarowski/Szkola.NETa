/*LINQ Challenge #13
W galeriach handlowych słyszy się już Last Christmas, Mariah Carey już jest wyciągana z szafy, trudno się więc nie domyślić, że nadchodzą święta.
W związku z tym dzisiaj temat świąteczny. Napisać metodę, która dla podanej daty w formacie yyyy-MM-dd zwróci po przecinku dni tygodnia dla 5 kolejnych świąt Bożego narodzenia (25 grudnia). 
Dla przykładu:
2022-11-08 zwróci "Niedziela, Poniedziałek, Środa, Czwartek, Piątek"

Szablon:*/

public static string FollowingChristmas(string date)
{
  return string.Join(", ",(Enumerable.Range(int.Parse(date[0..4]) + Math.Max(0, DateTime.Parse(date).CompareTo(DateTime.Parse(date[0..4] + "-12-25"))), 5).Select(x => DateTime.Parse(x + "-12-25").DayOfWeek)).ToArray());
}

/*Powodzenia 😛

PS. można wygrać uścisk Grzegorzów jeśli napisze się metodę przyjmującą jako parametr liczbę lat, dla których mają zostać zwrócone dni tygodnia ;P */
