// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arrayRealNumbers = new double[5];
for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = new Random().Next(1, 100) + new Random().NextDouble();
    Console.Write($"{arrayRealNumbers[i]:f3}   ");
}

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

for (int i = 1; i < arrayRealNumbers.Length; i++)
{
    if (maxNumber < arrayRealNumbers[i])
    {
        maxNumber = arrayRealNumbers[i];
    }
    if (minNumber > arrayRealNumbers[i])
    {
        minNumber = arrayRealNumbers[i];
    }
}

double decision = maxNumber - minNumber;

Console.WriteLine($"\nразница между между максимальным ({maxNumber:f2}) и минимальным({minNumber:f2}) элементами: {decision:f4}");

//Math.Round(); округление


/* работает не только с массивами
foreach (double item in collectionArrey) //нет гарантии что пройдет по коллекции по порядку
{
    Console.Write($"{item}:f3");
}

//тоже самое:

for (int i = 0; i < collectionArrey; i++)
{
    double item = collectionArrey[i];
}
*/