// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

string DOUBLENUMBER(int n)
{
    string text = string.Empty;
    for (int i = n; i > 0; i /= 2)
    {
        int d = i % 2;
        text = d + text;
    }
    return text;
}

int number = ReadNum("Введите число, а я переведу его в двоичное: ");
string result = DOUBLENUMBER(number);
Console.WriteLine(result);