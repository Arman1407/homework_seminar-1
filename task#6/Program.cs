﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
if (n % 2 == 0)
Console.WriteLine("число четное");
else
Console.WriteLine($"число не четное, остаток {n % 2}");