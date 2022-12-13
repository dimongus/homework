// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

// Console.WriteLine("number please");
// int number = int.Parse(Console.ReadLine());
// int result = GetLengthNumber(number);
// int GetLengthNumber(int number)
// {
//     int count = 0;
//     while (number != 0)
//     {
//         number = number / 10;
//         count++;
//     }
//     return count;
// }
// Console.WriteLine(result);


// ________________________________


//  Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4->24 5->120
// Console.WriteLine("number please");
// int a = int.Parse(Console.ReadLine());

// double multi = GetProductOfNumber(a);
// Console.WriteLine(multi);

// double GetProductOfNumber(int a)
// {
//     double multi = 1;
//     for (var i = 1; i <= a; i++)
//     {
//         multi = multi * i;
//     }
//     return multi;
// }


// Вывод массива,
// void PrintArray(int[] array)
// {
// Console.Write("[");
// for (var i = 0; i < array.Length-1; i++)
// {
// Console.Write($"{array[i]},");
// }
// Console.Write(array[array.Length-1]);
// Console.Write("]");
// }