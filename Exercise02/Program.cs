Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdNumber(int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }

    int unit = number % 10;
    return unit;
}

Console.WriteLine(ThirdNumber(number));