int[] arr = { 2, 5, 123, 65, 867, 6, 3, 7, 3, 8, 1, 6 };
int len = arr.Length;

void PrintArray( int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Reverse(int[] array)
{
    for ( int i = 0; i < (len / 2 - 1); i++)
    {
        int tmp = array[i];
        array[i] = array[len - 1 - i];
        array[len - 1 - i] = tmp;
    }

}

PrintArray(arr);
Reverse(arr);

PrintArray(arr);
