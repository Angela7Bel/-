void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);

Console.WriteLine();

double[] average = new double[matrix.GetLength(1)];
double sum = 0;
for (int j = 0; j<matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix [i,j];
        }
        average [j] = Math.Round((sum / matrix.GetLength(0)), 2);
        Console.Write($"{average[j]} \t");
        sum = 0;
}