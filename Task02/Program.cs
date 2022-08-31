// Задача 2:
// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите 1-е число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int min = num2;

if (num2 > max)
{
    max = num2;
    min = num1;
}
Console.WriteLine($"max = {max}, min = {min}");