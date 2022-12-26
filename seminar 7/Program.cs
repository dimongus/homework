// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9





// Console.WriteLine("Введите колличество строк");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов");
// int n = int.Parse(Console.ReadLine());
// double[,] array = new double[m, n];
// Random random = new Random();

/* FillArray(array); */
/* Console.WriteLine();
PrintArray(array); */

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         { Console.Write($"{array[i, j]}      "); }
//         Console.WriteLine();
//     }
// }


/* void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { array[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); }
    }
}
 */

// ________________________________________________________________________-
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

//  Console.WriteLine("Введите колличество строк");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов");
// int n = int.Parse(Console.ReadLine());



// int[,] array = CreateArray(m, n);

// Console.WriteLine();
// PrintArray(array);
// Console.WriteLine();



// void PrintArray(int[,] array)
// {
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CreateArray(int m, int n)
// {
//     int[,] array = new int[m, n];

//     Random random = new Random();


//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(10, 100);

//         }
//     }
//     return array;
// }
// Console.WriteLine("Введите number");
// int number = int.Parse(Console.ReadLine());


// if (number != array.GetLength(0) && number != array.GetLength(1)) Console.WriteLine($"{number} yes");
// else Console.WriteLine($"{number} -> такого числа в массиве нет");

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++=


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив

 Console.WriteLine("Введите колличество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int n = int.Parse(Console.ReadLine());


int[,] numbers = new int[m, n];
FillArray2D(numbers);
PrintArray2D(numbers);

double[] avgNumbers = new double[numbers.GetLength(1)];

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    avgNumbers[i] = result / numbers.GetLength(0);
}
PrintArray(avgNumbers);


void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}