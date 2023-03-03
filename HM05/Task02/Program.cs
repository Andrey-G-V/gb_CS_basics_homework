// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int[] FillArrey(int[] arrey, int start, int end)
{
    Random rnd = new Random();
    for(int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = rnd.Next(start, end+1);
    }
    return arrey;
}

int Summ(int[] arrey)
{
    int sum = 0;
    for(int i = 1; i < arrey.Length; i++)
    if(i % 2 != 0 )
    {
        sum += arrey[i];
    }
    return sum;
}

void PrintArrey(int[] collec){
    int count = collec.Length - 1;
    int position = 0;
    Console.Write("[");
    while(position < count){

        Console.Write($"{collec[position]}, ");
        position++;
    }
    Console.Write(collec[collec.Length - 1]);
    Console.Write("]");
}

int lengthArrey = CheckInput("Введите длинну массива: ");
int start = CheckInput("Введите минисальное число диапазаона значений");
int end = CheckInput("Введите нмаксимальное число диапазаона значений");

int[] arrey = СreateАrray(lengthArrey);
arrey = FillArrey(arrey, start, end);

Console.Write("Cумма эллементов не четных индексов массива: ");
PrintArrey(arrey);
Console.WriteLine($" равна {Summ(arrey)}");