Console.WriteLine("Введите число.");
int number = Convert.ToInt32(Console.ReadLine());
int x = number % 10;
if (x == 1)
{
    Console.WriteLine($"В комнате {number} програмист.");
}
else if (x == 2 | x == 3 | x == 4)
{
    Console.WriteLine($"В комнате {number} програмиста.");
}
else if (x == 5 | x == 6 | x == 7 | x == 8 | x == 9 | x == 0)
{
    Console.WriteLine($"В комнате {number} програмистов.");
}