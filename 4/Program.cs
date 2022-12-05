//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine(" Введите некое число");
int n = int.Parse(Console.ReadLine());
Console.Write("Число N = ");

if (n % 2 == 0) Console.Write($"{n} четное");
else { Console.Write($"{n} нечетное"); }

for (int i = 0; i <=(n+1); i++)
{
    if (i == n)
        break;
    Console.WriteLine(i);
}