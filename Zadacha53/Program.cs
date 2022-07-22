//Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. 

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] SwapLinesInMatrix(int[,] matrix, int row1, int row2)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[row1, i];
        matrix[row1, i] = matrix[row2, i];
        matrix[row2, i] = temp;
    }
    return matrix; 
}

int[,] arr = GetMatrix(4, 4, 0, 10);
PrintMatrix(arr);
SwapLinesInMatrix(arr, 0, arr.GetLength(0) - 1);
Console.WriteLine();
PrintMatrix(arr);