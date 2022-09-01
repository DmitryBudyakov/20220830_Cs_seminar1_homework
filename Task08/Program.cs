// Задача 8:
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите целое число больше 1: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 1)
{
    int count = 2;   // первое четное после 1
    while (count <= num)
    {
        if (count == num || (count == num-1)) Console.WriteLine(count); // чтобы последнее число в выводе было без , на конце
        else Console.Write($"{count}, ");
        count += 2;
    }
    
}
else Console.WriteLine("Ошибка ввода. Введиите целое число больше 1.");