// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int NumberRequest(string massadge)
{
    Console.WriteLine(massadge);
    string number = Console.ReadLine();
    int value = Convert.ToInt32(number);
    return value;
}

int number = NumberRequest("Введите трехзначное число");
int secondDigit;

if (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число!");
    return;
}
secondDigit = number/10 % 10;
Console.WriteLine("Вторая цифра " + secondDigit);