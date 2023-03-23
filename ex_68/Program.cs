// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Akkerman(int m, int n)
{
    if (m < 0 || n < 0) throw new Exception("M и N должно быть натуральным положительным числом");
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine(Akkerman(2, 3));
Console.WriteLine(Akkerman(3, 3));