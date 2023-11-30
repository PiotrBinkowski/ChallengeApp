int number = 111055;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();
char[] checkForCountert = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
int[] counter = new int[10];

for (int i = 0; i < letters.Length; i++)
{
    for (int j = 0; j < checkForCountert.Length; j++)
    {
        if(letters[i] == checkForCountert[j])
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