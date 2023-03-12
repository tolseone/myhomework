// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму
// чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadNumber(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Sumfrom1toNumber(int number)
{
    int sum = 0;
    for ( int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine(Sumfrom1toNumber(ReadNumber("Напишите число")));