// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Проверка без применения строк

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int CheckInput (string messege)
{
    Console.Write($"{messege} > ");
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if (isCorrect && value != 00000)
    {
        return value;
    }
    Console.WriteLine("fatal error: Вы ввели не число");
    Environment.Exit(1);
    return (0);
}

int ReverseNumber(int number)
{
    if (number >= 10000 && number <= 99999)
    {
            int reverseNumber = 0;
            while(number > 0)
            {
                int cache = number % 10;
                number /= 10;
                reverseNumber *= 10;
                reverseNumber += cache;
            }
            return reverseNumber;
    }
    Console.WriteLine("error: число не пятизначное");
    Environment.Exit(2);
    return (0);    
}

int number = CheckInput("Введите пятизначное число");
if(number == ReverseNumber(number))
{
   Console.WriteLine("Число палиндром"); 
}
else
{
   Console.WriteLine("Число НЕ палиндром");
}
