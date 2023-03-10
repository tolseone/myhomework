// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,10
// A (7,-5); B (1,-1) -> 7,21

double ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double x_A = ReadNum("Введите значение точки А по x");
double y_A = ReadNum("Введите значение точки А по y");
double x_B = ReadNum("Введите значение точки B по x");
double y_B = ReadNum("Введите значение точки B по y");

double result = Math.Sqrt( Math.Pow(x_B - x_A, 2) + Math.Pow(y_B - y_A, 2));
Console.WriteLine(result);