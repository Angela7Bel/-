Console.Clear();
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

if (n<100) 
    Console.WriteLine("Третьей цифры числа нет");
else {
    while (n>=1000) {
        n=n/10;
    }
    n = n%10;
    Console.WriteLine($"Третья цифра числа {n}");
}

