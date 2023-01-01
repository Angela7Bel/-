// Вычисляем сумму элементов на нечетных позициях

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = new Random().Next(0, 200);

Console.Write("Исходный массив: ");
PrintArray(array);

int sum = 0;
for (int i = 1; i < n; i+=2)
    sum += array[i];

Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}.");
