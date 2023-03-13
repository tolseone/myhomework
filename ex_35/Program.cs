// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива, значения
// которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте
// для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int Quantity_In_Range(int[] array, int left_border, int right_border)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)   // Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
    {
        if ( array[i] > left_border - 1 && array[i] < right_border + 1) quantity += 1;
    }
    return quantity;
}

int arrayLen = ReadNum("Введите длину массива: ");
int min_Value = ReadNum("Мин разброс чисел в массиве");
int max_Value = ReadNum("Мах разброс чисел в массиве");
int left_bord = ReadNum("Введите начало отрезка, в котором нужно подчитать количество элементов, входящих внутрь него");
int right_bord = ReadNum("Введите конец отрезка, в котором нужно подчитать количество элементов, входящих внутрь него");

int[] my_array = GenerateNewArray(arrayLen, min_Value, max_Value);
PrintArray(my_array);

Console.WriteLine($"Количество элементов в массиве, лежащих на отрезке [{left_bord}, {right_bord}] = {Quantity_In_Range(my_array, left_bord, right_bord)}");