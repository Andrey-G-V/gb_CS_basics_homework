// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArrey(int arreyLen)
{
    int[] arrey = new int[arreyLen];
    for (int i = 0; i < arrey.Length; i++)
    {
       arrey[i] = InputInt($" Введите {i + 1} эллемент массива"); 
    }
    return arrey;
}

int SearchPositive (int[] arrey)
{
    int count = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if(arrey[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArrey (int[] arrey)
{
    for (int i = 0; i < arrey.Length - 1; i++)
    {
        Console.Write($"{arrey[i]}, ");
    }
    Console.Write($"{arrey[arrey.Length-1]}");
    Console.WriteLine();
}

int lengthArr = InputInt("Введите количество эллементов");
int[] arrey = FillArrey(lengthArr);
PrintArrey(arrey);
Console.WriteLine($"количество положительных чисел в массиве: {SearchPositive(arrey)}");