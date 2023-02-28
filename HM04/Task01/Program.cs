// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

int Power(int number, int exponent)
{
    int power = 1;
    for (int i = 1; i <= exponent; i++)
    {
        power = power * number;
    }
    return power;
}

int number = CheckInput("Введите число");
int exponent = CheckInput("Введите степень");
Console.WriteLine($"Число {number} в степени {exponent} равно {Power(number, exponent)}");