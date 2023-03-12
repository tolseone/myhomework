// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int sum_digits(int number)
{
    int sum_dgts = 0;
    for (int i = number; i != 0; i /= 10)
    {
        int last_d = i % 10;
        sum_dgts += last_d;
    }
    return sum_dgts;
}

Console.WriteLine(sum_digits(ReadNum("Введите число, а я посчитаю сумму цифр в нём")));
