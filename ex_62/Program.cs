// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] m = new int[4,4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(i == 0 && j == 0) Console.Write("1 ");
            else Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int row, int column, int q)
{
    if(m[row, column] == q && row <= 4 && column <= 4)
    {
        m[row, column] = q;
        FillArray(row, column + 1, q += 1);
        FillArray(row + 1, column, q += 1);
        FillArray(row, column -1, q += 1);
        FillArray(row - 1, column, q += 1);
    }
}

PrintArray(m);
FillArray(0, 0, 1);
PrintArray(m);