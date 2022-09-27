Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int Dec(int number)
{
    int Decimal = number / 10;
    int Decimal2 = Decimal % 10;
    return Decimal2;
}

Console.WriteLine(Dec(number));