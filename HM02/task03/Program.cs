// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int NumberRequest(string massadge)
{
    Console.WriteLine(massadge);
    string number = Console.ReadLine();
    int value = Convert.ToInt32(number);
    return value;
}

bool checkNumber (int weekDayNum)
{
    if (weekDayNum > 0 && weekDayNum <= 7)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Не верное число!");
        return false;
    }
}

int weekDay = NumberRequest("Введите день недели(1-7) ");

if (checkNumber(weekDay))
{
    if (weekDay > 5)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Будний");
    }
}