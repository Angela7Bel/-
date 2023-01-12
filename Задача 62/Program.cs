void InputMatrix(int[,] matrix)
{
    void FillNext(int row, int col, int value)
    {
        matrix[row, col] = value;
        if (col < matrix.GetLength(1) - 1 && matrix[row, col + 1] == 0)
            FillNext(row, col + 1, value + 1);
        if (row < matrix.GetLength(0) - 1 && matrix[row + 1, col] == 0)
            FillNext(row + 1, col, value + 1);
        if (col > 0 && matrix[row, col - 1] == 0)
            FillNext(row, col - 1, value + 1);
        if (row > 0 && matrix[row - 1, col] == 0)
            FillUp(row - 1, col, value + 1);
    }

    void FillUp(int row, int col, int value)
    {
        matrix[row, col] = value;
        if (row > 0 && matrix[row - 1, col] == 0)
            FillUp(row - 1, col, value + 1);
        if (col < matrix.GetLength(1) - 1 && matrix[row, col + 1] == 0)
            FillNext(row, col + 1, value + 1);
    }
    FillNext(0, 0, 1);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Матрица:");
PrintMatrix(matrix);
