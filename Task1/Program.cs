// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("a^b=" + Math.Pow(a, b));

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
for (int i = 0; i < b; i++)
    c *= a;
{
    Console.WriteLine("{0}^{1}={2}", a, b, c);
    return 0;
}
