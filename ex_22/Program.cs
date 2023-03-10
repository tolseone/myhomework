// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int num = ReadNum("Введите число");
for( int i = 1; i <= num; i++)
{
    double sq = Math.Pow( i, 2);
    Console.Write($"{sq}, ");
}