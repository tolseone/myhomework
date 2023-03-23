// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void from_one_to_N(int ReadNum)
{
if (ReadNum < 1) return;
from_one_to_N(ReadNum - 1);
Console.Write($"{ReadNum} ");
}

from_one_to_N(ReadNum("Введите число"));