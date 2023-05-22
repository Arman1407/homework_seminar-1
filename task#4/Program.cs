// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int k = int.Parse(Console.ReadLine()!);

int Max(int n, int m, int k)
{
    int result = n;
    if(m > result) result = m;
    if(k > result) result = k;
    return result;
}
int max = Max(n, m, k);
Console.WriteLine(max);