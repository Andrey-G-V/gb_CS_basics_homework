//Задача 4 * : Напишите программу, которая заполнит спирально квадратный массив

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

// заполняет массив[1..n,1..m]
void FillMatrix(int[,] matrix) // заполнение массива по спирали к центру, по часовой стрелке.
{
    int startIndexRow = 0;
    int startIndexCol = 0;
    int endIndexRow = matrix.GetLength(0) - 1;
    int endIndexCol = matrix.GetLength(1) - 1;
    int element = 0;

    while (element < matrix.Length)
    {
        for (int j = startIndexCol; j <= endIndexCol && element < matrix.Length; j++) //заполняет первую строку
        {
            element++;
            matrix[startIndexRow, j] = element;

        }
        startIndexRow++;

        for (int i = startIndexRow; i <= endIndexRow && element < matrix.Length; i++) //заполняет последную колонку
        {
            element++;
            matrix[i, endIndexCol] = element;
        }
        endIndexCol--;

        for (int j = endIndexCol; j >= startIndexCol && element < matrix.Length; j--) //заполняет последнюю строку в обратном порядке
        {
            element++;
            matrix[endIndexRow, j] = element;
        }
        endIndexRow--;

        for (int i = endIndexRow; i >= startIndexRow && element < matrix.Length; i--) //заполнение первой колонки в обратном порядке
        {
            element++;
            matrix[i, startIndexCol] = element;
        }
        startIndexCol++;
    }
}


int rows = inputIn("Введите число строк массива-> ");
int columns = inputIn("Введите число столбцов массива-> ");
int[,] matrix = Creat2DArrey(rows, columns);
PrintMatrix(matrix);
FillMatrix(matrix);
PrintMatrix(matrix);