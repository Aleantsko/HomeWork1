Console.WriteLine("Введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Большее число: {a}");
    Console.WriteLine($"Меньшее число: {b}");
}
else
{
    Console.WriteLine($"Большее число: {b}");
    Console.WriteLine($"Меньшее число: {a}");
}