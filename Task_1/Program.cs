Console.WriteLine("Введите трехзначное число.");
int number = Convert.ToInt32(Console.ReadLine());
if (100 > number)
{
    Console.WriteLine("Введено некорректное число");
}
else if (number > 999)
{
    Console.WriteLine("Введено некорректное число");
}
else
{
    number = number / 10 % 10;
    Console.WriteLine("Вторая цифра числа " + number + ".");
}