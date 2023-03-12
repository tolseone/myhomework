// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double x_A = ReadNum("Введите значение точки А по x");
double y_A = ReadNum("Введите значение точки А по y");
double z_A = ReadNum("Введите значение точки А по z");

double x_B = ReadNum("Введите значение точки B по x");
double y_B = ReadNum("Введите значение точки B по y");
double z_B = ReadNum("Введите значение точки А по z");

double result = Math.Sqrt( Math.Pow(x_B - x_A, 2) + Math.Pow(y_B - y_A, 2) + Math.Pow(z_B - z_A, 2));
Console.WriteLine(result);