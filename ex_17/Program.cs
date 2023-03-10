// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int x = Prompt("Введите значение x = ");
int y = Prompt("Введите значение y = ");

if ( x > 0 )
{
    if ( y > 0)
    {
        Console.WriteLine("1-ая Четверть");
    }
    else if ( y < 0)
    {
        Console.WriteLine("2-ая Четверть");
    }
    else
    {
        Console.WriteLine("Не вводи y = 0, попробуй снова");
    }
}
else if ( x < 0 )
{
    if ( y > 0 )
    {
        Console.WriteLine("4-ая Четверть");
    }
    else if ( y < 0 )
    {
        Console.WriteLine("3-ая Четверть");
    }
    else 
    {
        Console.WriteLine("Не вводи y = 0, попробуй снова");
    }
}
else 
{
    Console.WriteLine("Не вводи x = 0, попробуй снова");
}