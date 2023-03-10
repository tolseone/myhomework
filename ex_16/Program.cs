// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int b = Convert.ToInt32(Console.ReadLine());

if (a == Math.Pow(b, 2) || b == Math.Pow(a, 2))
{
    Console.WriteLine("YES");
}
else Console.WriteLine("NO");