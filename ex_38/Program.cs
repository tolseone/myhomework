// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int ReadNum(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] GenerateNewArray(int len, int minValue, int maxvalue)
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

int Min_and_Max_ofArray(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        else if(array[i] < min) min = array[i];        
    }
    int del = max - min;
    return del;
}

int LenArray = ReadNum("Введите длину массива: ");
int l = ReadNum("Введите левый край разброса элементов массива: ");
int r = ReadNum("Введите правый край разброса элементов массива: ");
int[] my_array = GenerateNewArray(LenArray, l, r);
PrintArray(my_array);
Console.WriteLine($"Разница между max и min элементами массива = {Min_and_Max_ofArray(my_array)}");