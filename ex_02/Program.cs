Console.WriteLine("Напишите 2 числа каждое на отдельной строке: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.Write($"max = {a}, min = {b}");
}
else
{
    Console.Write($"max = {b}, min = {a}");
}