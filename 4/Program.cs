//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine(" Введите некое число");
int n = int.Parse(Console.ReadLine());
// Console.Write("Число N = ");

// if (n % 2 == 0) Console.WriteLine($"{n} четное");
// else { Console.WriteLine($"{n} нечетное"); }

if (n <= 1) Console.WriteLine($"нет возможности разбить число {n} на четные числа ");
else
{
    Console.WriteLine($"четные числа до числа {n}");
    for (int i = 2; i <= n; i = i + 2)
    {
        Console.WriteLine(i);
    }
}