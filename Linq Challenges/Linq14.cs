/*LINQ Challange #14
Dziękuję @Dżemojad za pomoc w trudnym dla mnie czasie onboardingu ❤️ 🙂

Dzisiaj na mięciutko - z podanego stringu musimy wyciągnąć tylko te wyrazy, które składają się z dużych liter (w całości).
Wyciągamy w formie stringu, znalezione wyrazy oddzielamy spacją 🙂

var input = "Trzeba mieć PIENIĄDZE i fantazję SYNKU";

Oczekiwany rezultat:
PIENIĄDZE SYNKU

Szablon do uzupełnienia:*/

private static string UpperFilter(string input)
    {
        return string.Join(" ", input.Split(" ").Where(x => x.All(x => char.IsUpper(x))));

    }

/*Enjoy 🙂*/
