// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GenerateMartix(int rows, int columns, int left_border, int right_border)
{
    int[,] matrix = new int[rows, columns];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     
        {
            matrix[i, j] = new Random().Next(left_border, right_border + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

// int[,] Prod_matrixs(int[,] matr_1, int[,] matr_2)  ХЗ КАК ПРАВИЛЬНО???
// {
//     for (int i = 0; i < matr_1.GetLength(0) i++)
//     {
//         for (int j = 0; j < matr_1.GetLength(1); j++)
//         {
//             for (int k = j; k < j + 1; k++)
//             {
//                 int[,] prod_matrix = matr_1[i, j] * matr_1[i, k];
                
//             }
//         }
        
//     }
// }

int[,] Prod(int[,] A, int[,] B)
{
    int[,] Prod_martix = 
}

int n = ReadNumber("Введите количество строк: ");
int m = ReadNumber("Введите количество столбцов: ");
int left = ReadNumber("Левая граница генерации чисел в матрице: ");
int right = ReadNumber("Правая граница генерации чисел в матрице: ");
int[,] my_matrix_1 = GenerateMartix(n, m, left, right);
int[,] my_matrix_2 = GenerateMartix(n, m, left, right);
PrintArray(my_matrix_1);
Console.WriteLine();
PrintArray(my_matrix_2);
Console.WriteLine("Произведение этих матриц: ");
