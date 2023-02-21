// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int NumberRequest(string massadge)
{
    Console.WriteLine(massadge);
    string number = Console.ReadLine();
    int value = Convert.ToInt32(number);
    return value;
}

int ThirdDigit (int number)
{
    while (number >= 1000)
    {
        number = number /10;
    }
    return number % 10;
}

int number = NumberRequest("В ведите целое положительное чсило");

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}

Console.WriteLine("Третья цифра " + ThirdDigit(number));