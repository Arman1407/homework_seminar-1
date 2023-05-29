// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



// 1 вариант

// Console.Clear();
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// int n = 2;

// if (N > 1)
// {
//     while (n <= N)
//     {
//         Console.Write(n +  ",");
//         n = n + 2;
//     }
// }
    
// 2 вариант

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
for (int n = 2; n <= N; n+=2)
    Console.WriteLine($"{n}");