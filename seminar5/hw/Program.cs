// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Не использовать метод Math.Pow

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Введите число А");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = int.Parse(Console.ReadLine());

// int extent = A;

// for (int i = 1; i < B; i++)
// {
// extent = extent * A;
// }
// Console.WriteLine("A в степени B равно: " + extent);

// ________________________________________________________________

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число ");
// int n = int.Parse(Console.ReadLine());
//   int sumN(int n)
//   {
    
//     int counter = Convert.ToString(n).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++){
//       advance = n - n % 10;
//       result = result + (n - advance);
//       n = n / 10;
//     }
//    return result;
//   }

// int sumNumber = sumN(n);
// Console.WriteLine($"Сумма цифр в числе {sumNumber}");

// ____________________________________________________

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]






Console.WriteLine("Введите ряд чисел, разделенных запятой : ");
int num = int.Parse(Console.ReadLine());

int [] numbers = new int[num];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = numbers [i]+1;
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}