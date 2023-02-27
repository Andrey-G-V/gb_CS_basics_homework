// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53                                 //0.13.18
int CheckInput (string messege)
{
    Console.Write($"{messege} > ");
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if (isCorrect)
    {
        return value;
    }
    Console.WriteLine("fatal error: Вы ввели не число");
    Environment.Exit(1);
    return (0);
}

(int x, int y, int z) GetPointCoords(string message) // ввод координат точки в виде кортежа
{
    Console.WriteLine($"{message}");
    int x = CheckInput("X");
    int y = CheckInput("Y");
    int z = CheckInput("Z");
    return(x, y, z);
}

double Distance((int x, int y, int z) point1, (int x, int y, int z) point2)
{
    double dist = Math.Sqrt(Math.Pow((point2.x - point1.x), 2)    //Mat.Sqrt - квадратный корень.
                          + Math.Pow((point2.y - point1.y), 2)    //Math.Pow(double x, double y) - возврашаетчисло X в степени Y
                          + Math.Pow((point2.z - point1.z), 2));
    return dist;
}

var pointA = GetPointCoords("Введите координаты точки А (x, y, z)"); // var представляет кортеж значений. с 3 компонентами вида (3, 6, 8)
var pointB = GetPointCoords("Введите координаты точки B (x, y, z)");

Console.WriteLine($"Растояне между точками состовляет {Distance(pointA, pointB):f2}"); // :f2} сокрашает вывод количества знаков после (,) (1,7320508075688772 > 1,73)

// Console.WriteLine(pointA);
// Console.WriteLine(pointB);