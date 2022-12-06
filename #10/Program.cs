// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// // 918 -> 1

Console.WriteLine("Введите 3х значное число");
int n = int.Parse(Console.ReadLine());

int lastDigit = (n / 10) % 10;


Console.WriteLine(lastDigit);