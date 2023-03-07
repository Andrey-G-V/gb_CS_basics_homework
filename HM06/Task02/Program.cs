// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE_1 = 1;
const int LINE_2 = 2;

double[] lineData_1 = InputLineData(LINE_1);
double[] lineData_2 = InputLineData(LINE_2);

if(ValidateLines(lineData_1, lineData_2))
{
    double[] coord = FindCoords(lineData_1, lineData_2);
    Console.Write($"Точка пересечений y={lineData_1[COEFFICIENT]}*x+{lineData_1[CONSTANT]} и y={lineData_2[COEFFICIENT]}*x+{lineData_2[CONSTANT]}");
    Console.WriteLine($" имеет координаты ({coord[X_COORD]}), ({coord[Y_COORD]})");
    
}

double Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"Введите коэфицент для {numberOfLine} прямой > ");
    lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой > ");
    return lineData;
}

double[] FindCoords(double[] lineData_1, double[] lineData_2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData_1[CONSTANT] - lineData_2[CONSTANT]) / (lineData_2[COEFFICIENT] - lineData_1[COEFFICIENT]);
    coord[Y_COORD] = lineData_1[CONSTANT] * coord[X_COORD] + lineData_1[CONSTANT];
    return coord;
}

bool ValidateLines(double[] lineData_1, double[] lineData_2)
{
    if(lineData_1[COEFFICIENT]==lineData_2[COEFFICIENT])
    {
        if(lineData_1[CONSTANT]==lineData_2[CONSTANT])
        {
            Console.WriteLine("Прямые совподают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые паралельны");
        }
    }
    return true;
}