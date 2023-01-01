// Вычисляем разницу между максимальным и минимальным элементами массива

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < n; i++)
    array[i] = new Random().Next(-1000, 1000) / 10.0;

Console.Write("Исходный массив: ");
PrintArray(array);

double min = array[0], max = min;
for (int i = 0; i < n; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}.");