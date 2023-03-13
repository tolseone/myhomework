// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний элемент, второй
// и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int [] GenerateProdedArray(int[] array)
{
    for 
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

int Sum_On_Nechet_i(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)   // Найдите сумму элементов массива под нечетным индексом : i = 1, 3, 5..... etc
    {
        sum += array[i];
    }
    return sum;
}

int arrayLen = ReadNum("Введите длину массива: ");
int min_Value = ReadNum("Мин разброс чисел в массиве");
int max_Value = ReadNum("Мах разброс чисел в массиве");

int[] my_array = GenerateNewArray(arrayLen, min_Value, max_Value);
PrintArray(my_array);

Console.WriteLine($"Сумма элементов массива под нечетными индексами = {Sum_On_Nechet_i(my_array)}");