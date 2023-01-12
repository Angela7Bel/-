int GetSum(int start, int end)
{
    if (start == end) return end;
    return (start < end) ? GetSum(start + 1, end) + start: 
                           GetSum(start, end + 1) + end;
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от {m} до {n} = {GetSum(m, n)}");
