// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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
            matrix[i, j] = rnd.Next(-9, 10);
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

void FindIndex(int[,] matrix, int i, int j)
{
    if(i > matrix.GetLength(0) && j > matrix.GetLength(1))
    {
        Console.WriteLine("Такой позиции в массиве не сушествует.");
    }
    else
    {
        Console.WriteLine(matrix[i-1,j-1]);
    }
}

int rows = 5;
int columns = 5;

int[,] matrix = (FillMatrix(Creat2DArrey(rows, columns)));
PrintMatrix(matrix);

int rowUser = InputIn("Введите строку > ");
int columnUser = InputIn("Введите столбец > ");
FindIndex(matrix, rowUser, columnUser);


