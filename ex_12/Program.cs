﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Напишите 2 числа, каждое на отдельной строке, а я скажу, кратно ли 1-ое 2-ому");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {a % b}");
}