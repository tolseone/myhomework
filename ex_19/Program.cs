// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool d_5(int number)
{
    int digits = 0;
    for ( int i = number; i != 0; i /= 10)
    {
        digits += 1;
    }
    if (digits == 5)
    {
        return true;
    }
    else return false;

}

string Polindrom(string number)
{
    string text = string.Empty;
    if (number[0] == number[4] && number[1] == number[3])
    {
        text = "Да, это полиндром";
        return text;
    }
    else text = "Нет, это не палиндом";
    return text;
}

int num = ReadNumber("Введите 5-тизначное число");
if (d_5(num))
{
    string n = Convert.ToString(num);
    Console.WriteLine(Polindrom(n));
}
else Console.WriteLine("Это не пятизначное число");