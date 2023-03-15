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

int[] LengthProdedArray(int[] array)
{
    if(array.Length % 2 == 0)
    return new int[array.Length / 2];
    else return new int[array.Length /2 + 1];
}
                                           
int [] GenerateProdedArray(int[] array)    
{
    int [] new_array = LengthProdedArray(array); 
    for (int i = 0; i < array.Length / 2; i++) 
    {
        new_array[i] = array[i] * array[array.Length -1 - i];
    }
    if(array.Length % 2 != 0)
    {
        new_array[new_array.Length - 1] = array[array.Length / 2];
    }
    return new_array;
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


int arrayLen = ReadNum("Введите длину массива: ");
int min_Value = ReadNum("Мин разброс чисел в массиве: ");
int max_Value = ReadNum("Мах разброс чисел в массиве: ");

int[] my_array = GenerateNewArray(arrayLen, min_Value, max_Value);
PrintArray(my_array);

int[] my_new_array = GenerateProdedArray(my_array);
PrintArray(my_new_array);