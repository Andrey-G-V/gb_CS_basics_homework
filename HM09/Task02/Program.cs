﻿// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int InputInt(string msg)
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int Numbers (int m, int n)
{
    if(m == n) return m;
    return Numbers(m+1, n)+ m; 
}

int m = InputInt("Введите число М -> ");
int n = InputInt("Введите число N -> ");
int summ = Numbers(m,n);
System.Console.WriteLine(summ);