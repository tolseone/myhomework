Console.WriteLine("Введите Число, а я вам выведу все целые числа");
int a = Convert.ToInt32(Console.ReadLine());
int num = a;
if (a > 0)
{
    while (num >= -a)
    {
        Console.Write(num);
        Console.Write(", ");
        num -= 1;
    }
}
else
{
    if (a < 0)
    {
        while (num <= -a)
        {
            Console.Write(num);
            Console.Write(", ");
            num += 1;
        }
    }
    else
    {
        Console.Write("0");
    }

}