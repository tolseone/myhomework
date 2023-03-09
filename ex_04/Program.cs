Console.WriteLine("Введите 3 числа, а я выведу максимальное");

int Max(int num_1, int num_2, int num_3)
{
    int res = num_1;
    if (num_2 > res) res = num_2;
    if (num_3 > res) res = num_3;
    return res;
}



int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());


int max = Max(a, b, c);
Console.WriteLine(max);