// Напишите программу, которая
// принимает на вход число и выдаёт количество
// цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int quantity_digits(int number)
{
    int quantity = 0;
    for (int i = number; i != 0; i /= 10)
    {
        quantity += 1;
    }
    return quantity;
}

Console.WriteLine(quantity_digits(ReadNum("Введите число, а я посчитаю количество цифр в нём")));