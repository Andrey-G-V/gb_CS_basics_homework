//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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

void Sort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp;
        
        for (int j = 0, nextIndex = 1; j < matrix.GetLength(1)-1; j++, nextIndex++)
        {

            int indexMax = j;
            int maxValue = matrix[i,j];
            int FindNewMax = 0;

            for (int k = nextIndex ; k < matrix.GetLength(1); k++)
            {   
                
                if(matrix[i,k] > maxValue)
                {
                    maxValue = matrix[i,k];
                    indexMax = k;
                    FindNewMax++;
                }

            }
            if(FindNewMax != 0)
            {
                temp = matrix[i,j];
                matrix[i,j] = matrix[i, indexMax];
                matrix[i, indexMax] = temp;
            }
        }
    }
}



int rows = inputIn("Введите число строк массива-> ");
int columns = inputIn("Введите число столбцов массива-> ");
int[,] matrix = Creat2DArrey(rows, columns);
PrintMatrix(FillMatrix(matrix));
Sort(matrix);
PrintMatrix(matrix);