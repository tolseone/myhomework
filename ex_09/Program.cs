int a = new Random().Next(10,100000);
int max_d = -1;
for (int i = a; i > 0; i /= 10)
{
    if (i % 10 > max_d)
    {
    max_d = i % 10;
    }
}
Console.WriteLine("Нарандомилось число: " + a);
Console.WriteLine("Наибольшая цифра: " + max_d);