// Задайте массив. Напишите программу,
// которая определяет, присутствует ли заданное
// число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int [] GenerateNewArray(int len, int minValue, int maxvalue)
{
    int [] my_array = new int [len];
    Random random = new Random();
    for (int i = 0; i < len; i++)
    {
        my_array[i] = random.Next(minValue, maxvalue + 1);
    }
    return my_array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

string Here_or_Not(int[] array, int num)
{
    string text = string.Empty;
    for(int i = 0; i < array.Length; i++)
    {
    if (array[i] == num)
    {
        text = "YES";
        break;
    }
    else text = "NOPE";
    }
    return text;
}

int quantity = ReadNum("Введите количество элементов в массиве");
int min = ReadNum("нижнее значение элементов");
int max = ReadNum("верхнее значение элементов");
int num = ReadNum("Введите число, наличие которой надо проверить в массиве");
int[] my_arr = GenerateNewArray(quantity, min, max);
PrintArray(my_arr);

Console.WriteLine(Here_or_Not(my_arr, num));
