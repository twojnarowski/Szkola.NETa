/*LINQ Challange #1
Na początek coś prostego - mamy zadaną tablicę liczb całkowitych, należy obliczyć sumę ich kwadratów.
var input = new int[] {1, 2, 3};
Oczekiwany rezultat:
14
Szablon na szybki start:*/

private static int SquareSum(int[] input)
    {
        return input.Sum(x => Math.Pow(x, 2));
    } 