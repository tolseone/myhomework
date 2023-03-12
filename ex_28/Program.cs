// Напишите программу,
// которая принимает на вход число N и
// выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Prod(int number)
{
    int prod = 1;
    for (int i = 1; i <= number; i++)
    {
    prod *= i;
    }
    return prod;
}

Console.WriteLine(Prod(ReadNum("напишите число, а я выведу Вам произведение чисел от 1 до него")));