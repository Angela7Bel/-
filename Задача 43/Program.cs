Console.Clear();

Console.Write("Введите К1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите К2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = ((b2-b1)/(k1-k2));
double y = k1 * ((b2-b1)/(k1-k2)) + b1;

Console.Write($"Точка пересечения: {x}, {y}");