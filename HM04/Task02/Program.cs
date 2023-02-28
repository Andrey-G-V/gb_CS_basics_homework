// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CheckInput (string messege)
{
    Console.Write($"{messege} > ");
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if (isCorrect)
    {
        return value;
    }
    Console.WriteLine("fatal error: Вы ввели не число");
    Environment.Exit(1);
    return (0);
}

int SumDigit (int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

int number = CheckInput("Ввудите число");
Console.WriteLine($"Сумма чисел {number} равна {SumDigit(number)}");
