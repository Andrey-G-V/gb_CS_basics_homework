// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputIn(string msg)
{
    System.Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Creat2DArrey(int rows, int col)
{
    int[,] matrix = new int[rows, col];
    return matrix;
}

int[,] FillMatrix(int[,] matrix)
{
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t"); // ($"{matrix[i, j]}\t"); Знак такбуляции
        }
        System.Console.WriteLine();
    }
}

void AvgCol (int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double avg = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            avg = avg + matrix[i,j];
        }
        Console.Write($"{avg / matrix.GetLength(0):f2}    ");
    }
}
int rows = InputIn("Введите количество строк в массиве > ");
int columns = InputIn("Введите количество столбцов в массиве > ");
int[,] arrey = FillMatrix(Creat2DArrey(rows, columns));

PrintMatrix(arrey);
System.Console.WriteLine();
AvgCol(arrey);
