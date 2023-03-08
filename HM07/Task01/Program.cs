// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputIn(string msg)
{
    System.Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] Creat2DArrey(int rows, int col)
{
    double[,] matrix = new double[rows, col];
    return matrix;
}

double[,] FillMatrix(double[,] matrix)
{
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-9, 10) + new Random().NextDouble();
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]:f1}\t"); // ($"{matrix[i, j]}\t"); Знак такбуляции
        }
        System.Console.WriteLine();
    }
}

int rows = InputIn("Введите количество строк в массиве > ");
int columns = InputIn("Введите количество столбцов в массиве > ");

PrintMatrix(FillMatrix(Creat2DArrey(rows, columns)));