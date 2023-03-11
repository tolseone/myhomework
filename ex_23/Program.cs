// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int num = ReadNum("Введите число");
for( int i = 1; i < num; i++)
{
    double sq = Math.Pow( i, 3);
    Console.Write($"{sq}, ");
}
Console.WriteLine($"{Math.Pow(num, 3)}.");