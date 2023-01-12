int Func(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Func(m - 1, 1);
    return Func(m - 1, Func(m, n - 1));
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккерамана A({m},{n}) = {Func(m, n)}");