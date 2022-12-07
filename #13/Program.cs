// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Рандомное число = ");
// Random random = new Random();
// int randomn = random.Next(10, 100000);
// Console.WriteLine(randomn);
Console.WriteLine("Введите число от 10 до 100 000");
int randomn = int.Parse(Console.ReadLine());
if (10000 <= randomn)
{
    int digit = (randomn / 100) % 10;
    Console.WriteLine($"3e число {digit}");
}
else if (1000 <= randomn)
{
    int digit = (randomn / 10) % 10;
    Console.WriteLine($"3e число {digit}");
}
else if (100 <= randomn)
{
    int digit = randomn % 10;
    Console.WriteLine($"3e число {digit}");
}
else { Console.WriteLine($"У числа {randomn} нету трутьей цифры"); }