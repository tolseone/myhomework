// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int day = Prompt("Введите день недели, на выходе узнайте, выходной ли это или нет");

if (day >= 1 && day <= 7)
{
    if (day == 6 || day == 7) Console.WriteLine("Ура, выходной!");
    else Console.WriteLine("Опять работа :(");
}
else Console.WriteLine("Пожалуйста, введите значение от 1 до 7 включительно");