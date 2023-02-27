// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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

// void Exponent1 (int number)    
// {   
//     int startValue = 1;
//     while(startValue <= number)
//     {   
//         Console.Write($"{startValue * startValue * startValue} ");
//         startValue ++;
//     }        
// }
void PrintArrey(int[] collec){
    int count = collec.Length;
    int position = 0;
    while(position < count){

        Console.Write($"{collec[position]} ");
        position++;
    }
}

int[] Exponent (int[] arrey)    
{   
    int startValue = 1;
    while(startValue <= arrey.Length)
    {   
        arrey[startValue - 1] = startValue * startValue * startValue;
        startValue ++;
    }
    return arrey; 

}

int number = CheckInput("Введите натуральное число");
int[] arrey = new int[number];
PrintArrey(Exponent(arrey));
