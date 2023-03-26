int ReadLengthArray(string msgToUser) // Метод, который считывает данные от пользователия и запоминает длину массива
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

string ReadElementsofArray(string msgToUser) // Метод, который считывает данные от пользователя и заполняет массив элементами, которые задал пользователь
{
    Console.WriteLine(msgToUser);
    string value = Console.ReadLine();
    return value;
}

int LengthofSecondArray(string[] array) // Метод, с помощью которого мы узнаем длину нужного для решения задачи массива
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) result++;
    }
    return result;
}

string [] GenerateNewArray(int len) // Метод, который нужен для того, чтобы сгенерировать массив с заданными от пользователя длиной и наполнением массива
{
    string [] my_array = new string [len];
    Random random = new Random();
    for (int i = 0; i < len; i++)
    {
        my_array[i] = ReadElementsofArray($"Введите {i + 1} элемент массива: ");
    }
    return my_array;
}

void SecondArrayWithIF(string[] array1, string[] array2) // Метод, который нужен для того, чтобы сгенерировать финальный массив
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3) // Узнаем, подходит ли текущий элемент для заполнения финального массива
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array) // Метод, который выводит массив на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

int array_len = ReadLengthArray("Введите количество элементов в массиве: ");
string [] array_1 = GenerateNewArray(array_len); // Генерация массива с заданой длиной и наполнением, которые указал пользователь
PrintArray(array_1); // Метод для вывода на экран массива, который ввёл пользователь

string[] array_2 = new string[LengthofSecondArray(array_1)]; // Резервация памяти на компьютере для финального массива с заданной длиной, полученной из метода LengthofSecondArray

SecondArrayWithIF(array_1, array_2); // Генерация и заполнение финального массива
PrintArray(array_2); // Метод для вывода на экран финального массива