using System.Reflection.Metadata;
using ChalengeApp;

Employee employee1 = new Employee("Izabela", "Kowalska", 21);
Employee employee2 = new Employee("Łucja", "Nowak", 30);
Employee employee3 = new Employee("Jakub", "Baczyński", 36);

employee1.AddScore(9);
employee1.AddScore(2);
employee1.AddScore(8);
employee1.AddScore(3);
employee1.AddScore(1);

employee2.AddScore(9);
employee2.AddScore(3);
employee2.AddScore(2);
employee2.AddScore(6);
employee2.AddScore(9);

employee3.AddScore(9);
employee3.AddScore(7);
employee3.AddScore(1);
employee3.AddScore(9);
employee3.AddScore(8);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

List<Employee> champions = new List<Employee>();

int maxResult = -1;
//Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
    }
}

foreach(var champion in employees)
{
    if(champion.Result == maxResult)
    {
        champions.Add(champion);
    }
}



if(champions.Count == 3)
{
    Console.WriteLine("Wszyscy pracownicy uzyskali tę samą ilość punktów.");
    foreach(var champion in champions)
    {
        Console.WriteLine();
        Console.WriteLine($"Imię: {champion.Name}");
        Console.WriteLine($"Nazwisko: {champion.Surname}");
        Console.WriteLine($"Wiek: {champion.Age}");
        Console.WriteLine($"Wynik: {champion.Result}");
        Console.WriteLine();
    }
}
else if(champions.Count == 2)
{
    Console.WriteLine($"{champions[0].Name} i {champions[1].Name} zdobyli tę samą ilość punktów.");
    foreach(var champion in champions)
    {
        Console.WriteLine();
        Console.WriteLine($"Imię: {champion.Name}");
        Console.WriteLine($"Nazwisko: {champion.Surname}");
        Console.WriteLine($"Wiek: {champion.Age}");
        Console.WriteLine($"Wynik: {champion.Result}");
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine($"Wygrywa {champions[0].Name}.");
    Console.WriteLine();
    Console.WriteLine($"Imię: {champions[0].Name}");
    Console.WriteLine($"Nazwisko: {champions[0].Surname}");
    Console.WriteLine($"Wiek: {champions[0].Age}");
    Console.WriteLine($"Wynik: {champions[0].Result}");
    Console.WriteLine();
}