Console.WriteLine("Введите любое 3-ёх значное число, а я выведу его последнюю цифру");
int n = Convert.ToInt32(Console.ReadLine());
if ( n > 99 && n < 1000 )
{
    int d = n % 10;
    Console.WriteLine("Последняя цифра: " + d);
}
else
{
    Console.WriteLine("Ты за меня кого держишь?)");
}