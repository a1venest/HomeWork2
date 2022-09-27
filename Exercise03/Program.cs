Console.WriteLine("Введите номер дня недели от 1 до 7, где 1 - это понедельник, а 7 - это воскресенье:");
int day = Convert.ToInt32(Console.ReadLine());

void DayOfWeek(int day)
{
    if (day ==6)
    {
        Console.WriteLine("Суббота, Выходной!");
    }
    else if (day ==7)
    {
        Console.WriteLine("Воскресенье, выходной! Но завтра на работу(");
    }
    else
    {
        Console.WriteLine("Работать негры, еще не выходной!");
    }
}

DayOfWeek(day);



