﻿// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalValue(int n)
{
Console.Write(n + " ");
if (n > 1) NaturalValue(n - 1);
}

NaturalValue(5);
Console.WriteLine();
NaturalValue(8);