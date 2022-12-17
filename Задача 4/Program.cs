// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("а =");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b =");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c =");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;
Console.Write("max = ");
Console.WriteLine(max);

