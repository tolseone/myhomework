// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int [] GenerateNewMinusArray(int[] array)
{
    int[] my_new_array = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        my_new_array[i] = -array[i];
    }
    return my_new_array;
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

int quantity = ReadNum("Введите длину массива: ");
int min = ReadNum("нижнее значение элементов: ");
int max = ReadNum("верхнее значение элементов: ");
int[] my_arr = GenerateNewArray(quantity, min, max);
PrintArray(my_arr);
my_arr = GenerateNewMinusArray(my_arr);
PrintArray(my_arr);