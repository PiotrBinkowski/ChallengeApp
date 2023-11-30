int number = 9010888;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();
string numbersForCheck = "0123456789";
char[] checkForCounter = numbersForCheck.ToArray();
int[] counter = new int[10];

for (int i = 0; i < letters.Length; i++)
{
    for (int j = 0; j < checkForCounter.Length; j++)
    {
        if(letters[i] == checkForCounter[j])
        {
            counter[j]++;
        }
    }
}

Console.WriteLine($"Wynik dla liczby: {numberAsString}");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i.ToString() + " => " + counter[i].ToString());
}