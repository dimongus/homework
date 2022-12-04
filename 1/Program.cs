//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 1е число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2е число");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write($"Число {a} больше числа {b}");
}
else
{
    Console.WriteLine($"Число {a} меньше числа {b}");
}
