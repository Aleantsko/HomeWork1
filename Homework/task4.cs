﻿Console.WriteLine("Введите число N:");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}