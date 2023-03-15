// Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool itisTriangle(int a, int b, int c)
{
    if(a + b > c && a + c > b && b + c > a)
    return true;
    else return false;
}

int a = ReadNum("Введите сторону А: ");
int b = ReadNum("Введите сторону B: ");
int c = ReadNum("Введите сторону C: ");
if(itisTriangle(a, b, c)) Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} - существует!");
else Console.WriteLine($"Треугольника со сторонами {a}, {b}, {c} - не существует");