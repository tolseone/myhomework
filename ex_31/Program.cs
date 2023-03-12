// Задайте массив из 12 элементов,
// заполненный случайными числами из промежутка [-9,
// 9]. Найдите сумму отрицательных и положительных
// элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных
// равна -20

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

(int, int) Sum_Array(int[] array)
{
    int summary_plus = 0;
    int summary_minus = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if ( array[i] >= 0) summary_plus += array[i];
        else summary_minus += array[i];
    }
    return (summary_plus, summary_minus);
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

int quantity = ReadNum("Введите количество элементов в массиве");
int min = ReadNum("нижнее значение элементов");
int max = ReadNum("верхнее значение элементов");
int[] my_arr = GenerateNewArray(quantity, min, max);
PrintArray(my_arr);

Console.WriteLine(Sum_Array(my_arr));