Console.Write("Введите число: ");
string? r = Console.ReadLine();
int sum = 0;

for (int i = 0; i < r.Length; i++)
{
    //if (char.IsNumber(s[i]))
    //{
        sum += int.Parse(r[i].ToString());

    //}

}

Console.Write(sum);
