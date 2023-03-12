// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double Finally(double num, int stepen)
{
    double res = Math.Pow(num, stepen);
    return res;
}

double a = Convert.ToDouble(ReadNumber("Введите число А"));
int b = ReadNumber("Введите Число B");

Console.WriteLine(Finally(a, b));