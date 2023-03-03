// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int CheckInput (string message)
{
    int value;
    Console.WriteLine(message);
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if(isCorrect)
    {
        return value;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int[] СreateАrray(int lengthArrey)
{
    int[] arrey = new int[lengthArrey];
    return arrey;
}

int[] FillArrey(int[] arrey)
{
    Random rnd = new Random();
    for(int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = rnd.Next(100, 1000);
    }
    return arrey;
}

int EvenNumbers(int[] arrey)
{
    int count = 0;
    for(int i = 0; i < arrey.Length; i++)
    if(arrey[i] % 2 == 0 )
    {
        count++;
    }
    return count;
}

void PrintArrey(int[] collec){
    int count = collec.Length - 1;
    int position = 0;
    Console.Write("[");
    while(position < count){

        Console.Write($"{collec[position]} ");
        position++;
    }
    Console.Write(collec[collec.Length - 1]);
    Console.Write("]");
}

int lengthArrey = CheckInput("Введите длинну массива: ");
int[] arrey = СreateАrray(lengthArrey);
arrey = FillArrey(arrey);
Console.Write("Четных чисел в массиве ");
PrintArrey(arrey);
Console.WriteLine($" - {EvenNumbers(arrey)}");