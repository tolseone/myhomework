//  Напишите программу, которая выводит третью цифру заданного 
//  числа или сообщает, что третьей цифры нет. 
//  (номер цифры считается от левого края)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int num = Prompt("Введите любое число, а программа Вам покажет 3-юю цифру слева направо");
if (num < 100 && num > -100)
{
    Console.WriteLine("Третьей цифры нет, введите число больше 99 или меньше -99");
}
else 
{
    while (num > 1000 || num < -1000)
    {
        num /= 10;
    }
    Console.WriteLine($"Третья цифра: {num % 10}");
}