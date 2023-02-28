// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]6, 1, 33 -> [6, 1, 33]


// int[] GenerateArrey(int[] arrey)
// {
//     for(int i = 0; i < arrey.Length; i++)
//     {
//         arrey[i] = new Random().Next(1 ,100);
//     }
//     return arrey;
// }

void PrintArrey(int[] collec){
    int count = collec.Length - 1;
    int position = 0;
    Console.Write("[");
    while(position < count){

        Console.Write($"{collec[position]} ");
        position++;
    }
    Console.Write(collec[collec.Length - 1]);
    Console.WriteLine("]");
}

int[] arrey = new int[8];

for(int i = 0; i < arrey.Length; i++)
{
    arrey[i] = new Random().Next(1 ,100);
}

// GenerateArrey(arrey);
PrintArrey(arrey);