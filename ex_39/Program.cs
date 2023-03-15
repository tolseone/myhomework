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


void Reverse(int[] array)
{
    for ( int i = 0; i < (array.Length / 2); i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }

}

int arrayLen = ReadNum("Введите длину массива: ");
int min_Value = ReadNum("Мин разброс чисел в массиве: ");
int max_Value = ReadNum("Мах разброс чисел в массиве: ");

int[] my_array = GenerateNewArray(arrayLen, min_Value, max_Value);
PrintArray(my_array);

Reverse(my_array);
PrintArray(my_array);