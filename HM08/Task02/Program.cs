// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.



int inputIn(string msg)
{
    System.Console.Write($"{msg}");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] Creat2DArrey(int rows, int columns)
{
    int[,] arrey = new int[rows, columns];
    return arrey;
}

int[,] FillMatrix(int[,] arrey)
{
    Random rnd = new Random();
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i,j] = rnd.Next(0,10);
        }
    }
    return arrey;
}

void PrintMatrix(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintArrey(int[] arrey)
{
    for(int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]} ");
    }
    Console.WriteLine();
}

int[] SumRow (int[,] matrix)
{
    int[] arrey = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        arrey[i] = sum;
    }
    return arrey;
}

void MinRow (int[] arrey)
{
    int min = arrey[0];
    int indexMin = 0;
    for (int i = 1; i < arrey.Length; i++)
    {
        if (arrey[i]<min)
        {
            min = arrey[i];
            indexMin = i;
        }
    }
    System.Console.WriteLine($"первоя строка с наименьшей ссумой {indexMin+1}");
}

int rows = inputIn("Введите число строк массива-> ");
int columns = inputIn("Введите число столбцов массива-> ");
int[,] matrix = Creat2DArrey(rows, columns);
PrintMatrix(FillMatrix(matrix));
int[] arrey = SumRow(matrix);
PrintArrey(arrey);
MinRow(arrey);
