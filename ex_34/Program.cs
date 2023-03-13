//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool CorrectNum(int minValue, int maxValue)
{
    if ( 99 < minValue && maxValue < 1000) return true;
    else return false;
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

int Quantity_Chet(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] % 2 == 0) quantity += 1;
    }
    return quantity;
}

int arrayLen = ReadNum("Введите длину массива: ");
int min_Value = ReadNum("Мин разброс чисел в массиве");
int max_Value = ReadNum("Мах разброс чисел в массиве");

if(CorrectNum(min_Value, max_Value))
{
    int[] my_array = GenerateNewArray(arrayLen, min_Value, max_Value);
    PrintArray(my_array);
    Console.WriteLine($"Количество чётных элементов в массиве: {Quantity_Chet(my_array)}");
}
else Console.WriteLine("Введите правильный разброс элементов массива [100, 999]");