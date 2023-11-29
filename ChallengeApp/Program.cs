var name = "Ewa";
var female = true;
var age = 33;

if (female == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && female == true && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (female == false && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (female == false && age >= 18)
{
    Console.WriteLine("Pełnoletni mężczyzna");
}