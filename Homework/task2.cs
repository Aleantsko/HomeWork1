Console.WriteLine("Введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > b)
{
    max = a;
    if (a < c)
    {
        max = c;
    }
}
else
{
    max = b;
    if (b < c)
    {
        max = c;
    }
}

Console.WriteLine($"Большее число: {max}");