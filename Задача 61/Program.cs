int  ( intvalue, int n) => (value > =  0) ? (value % n) : (value % n) + n;

void FillMatrix(int[,] matrix)
{
    int = = matrix.GetLength(1);
    matrix[0, colCount / 2] = 1;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
            matrix [i, j] = matrix[i-1, NormIndex(j - 1, colCount)] + 
                           matrix[i-1, NormIndex(j  +  1, colCount)];
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix [i, j] == 0)
                Console.Write ($" \t");
            else    
                Console.Write($"{matrix [i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк треугольника Паскаля: ");
int  = = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, (size - 1) * 2  +1];
FillMatrix(matrix);
Console.WriteLine("Треугольник Паскаля:");
PrintMatrix(matrix);
