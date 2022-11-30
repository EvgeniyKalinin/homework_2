Console.WriteLine("Введите число.");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    if (number <= 7)
    {
        if (number <= 5)
        {
            Console.WriteLine("Будний день.");
        }
        else
        {
            Console.WriteLine("Выходной день.");
        }
    }
    else
    {
        Console.WriteLine("Введено некорректное число.");
    }
}
else
{
    Console.WriteLine("Введено некорректное число.");
}