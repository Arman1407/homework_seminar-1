﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
if (n > m)
    Console.WriteLine(n);
else if (n < m)
    Console.WriteLine(m);
else if (n == m)
    Console.WriteLine("Числа равны");
