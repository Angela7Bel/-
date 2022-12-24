Console.Clear();
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

if ((n>7) || (n<=0)) 
    Console.WriteLine("Такого дня недели нет");
else if ((n==7) || (n==6)) 
    Console.WriteLine("да");
else 
    Console.WriteLine("нет");

