// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumMtoN(int m, int n)
{
    if(m > n) throw new Exception("M должно быть меньше N");
    if(m < n) return n + SumMtoN(m, n-1);
    return n;
}

int first_num = ReadNum("Введите начальное число: ");
int second_num = ReadNum("Введите последнее число: ");
Console.WriteLine($"Сумма чисел в промежутке от {first_num} до {second_num} = {SumMtoN(first_num, second_num)}");

