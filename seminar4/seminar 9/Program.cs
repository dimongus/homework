// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите n: ");
// int n = int.Parse(Console.ReadLine());

// int count = 2;
// PrintNumber(n, count);
// Console.Write(1);

// void PrintNumber(int n, int count)
// {
//   if (count > n) return;
//   PrintNumber(n, count + 1);
//   Console.Write(count + ", ");
// }



//=====================================================


// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите первое натуральное число: ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите второе натуральное число: ");
// int N = int.Parse(Console.ReadLine());
// int sum = 0;
// void SumNuber(int M)
// {
//     sum += M;
//     M++;
//     if(M > N)
//     {
//         Console.Write($"Сумма натуральных чисел: {sum}");
//         return;
//     }
//     SumNuber(M);
// }
// SumNuber(M);
  
//=====================================================
// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



// Console.Write("Введите число m: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = int.Parse(Console.ReadLine());

// int AkkermanFunction(int m, int n)
// {
//     if(m == 0)
//     return n + 1;
//     if(n == 0)
//     return AkkermanFunction(m - 1, 1);
//     if(m > 0 && n > 0)
//     return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
//     return AkkermanFunction(m, n);
// }
// Console.WriteLine($" A({m},{n}) = {AkkermanFunction(m, n)}");