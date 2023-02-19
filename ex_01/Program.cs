Console.WriteLine("Введите 2 числа на отдельных строчках каждое: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(a == Math.Pow(b, 2))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
