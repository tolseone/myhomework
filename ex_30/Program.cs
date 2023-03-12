// Напишите программу, которая
// выводит массив из 8 элементов,
// заполненный нулями и единицами в
// случайном порядке.
// [1,0,1,1,0,1,0,0]
int [] GenerateNewArray()
{
    int [] my_array = new int [8];
    Random random = new Random();
    for (int i = 0; i < 8; i++)
    {
        my_array[i] = random.Next(0, 2);
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
    Console.Write($"{array[array.Length - 1]}]");
}


int[] my_arr = GenerateNewArray();
PrintArray(my_arr);
