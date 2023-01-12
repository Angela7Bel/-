void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
    }
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

int[,] MultiMatrix(int[,] matrA, int[,] matrB)
{
    int[,] result = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int tmp = 0;
            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                tmp += matrA[i,k] * matrB[k,j];
            }
            result[i,j] = tmp;
        }
    }
    return result;
}

Console.Clear();
Console.Write("Введите размер 1й матрицы: ");
int[] sizeA = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrixA = new int[sizeA[0], sizeA[1]];
Console.Write("Введите размер 2й матрицы: ");
int[] sizeB = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrixB = new int[sizeB[0], sizeB[1]];
if (sizeA[1] != sizeB[0])
{
    Console.WriteLine("ОШИБКА! Количество столбцов первой матрицы должно совпадать с количеством строк во второй!");
    return;
}
InputMatrix(matrixA);
InputMatrix(matrixB);
Console.WriteLine("Исходная 1я матрица:");
PrintMatrix(matrixA);
Console.WriteLine("Исходная 2я матрица:");
PrintMatrix(matrixB);
int[,] matrixC = MultiMatrix(matrixA, matrixB);
Console.WriteLine("Результат умножения:");
PrintMatrix(matrixC);
