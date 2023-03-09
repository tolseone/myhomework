Console.WriteLine("Напишите число, а я проверю, делится ли оно на 2 без остатка или нет");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.Write("Конечно же делится и получится: " + a / 2);
}
else
{
    Console.Write("Ohh NO!");
}