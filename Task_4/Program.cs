int n = 1;
while (n < 101)
{
    if (n % 3 == 0)
    {
        if (n % 5 == 0)
        {
            Console.Write("FizzBuzz ");
            n++;
            continue;
        }
        else
        {
            Console.Write("Fizz ");
            n++;
            continue;
        }
    }
    if (n % 5 == 0)
    {
        if (n % 3 == 0)
        {
            Console.Write("FizzBuzz ");
            n++;
            continue;
        }
        else
        {
            Console.Write("Buzz ");
            n++;
            continue;
        }
    }
    else
    {
        Console.Write(n + " ");
        n++;
    }
}