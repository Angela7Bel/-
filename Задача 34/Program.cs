Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99 || n < 1000);
{
n = / 10;
n = % 10;
Console.WriteLine();
}
else
    Console.WriteLine("не трёхзначное число");
