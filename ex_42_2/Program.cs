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

int LenArray(int number)
{
    int count = 0;
    for (int i = number; i > 0; i /= 2)
    {
        count += 1;
    }
    return count;
}

int[] DoubleNUM(int num)
{
    int[] my_num = new int[(LenArray(number))];
    for (int i = 0; i < LenArray(number); i++)
    {
        for (int j = num; j > num; j /= 2)
        {
            Console.WriteLine($"{my_num[i]}");
        }    
    }
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