// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void from_M_to_N(int first_num, int second_num)
{
    if (second_num < first_num) return;
    from_M_to_N(first_num, second_num - 1);
    Console.Write($"{second_num} ");
}

int m = ReadNum("Введите первое число: ");
int n = ReadNum("Введите последнее число: ");

from_M_to_N(m, n);

