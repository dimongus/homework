// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Не использовать метод Math.Pow

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Введите число А");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = int.Parse(Console.ReadLine());
// int Answer(int A, int B)
// {
// int extent = A;
// for (int i = 1; i < B; i++)
// {
// extent = extent * A;
// }
// }


// ________________________________________________________________

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число ");
// int n = int.Parse(Console.ReadLine());
//   int SumN(int n)
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

// int sumNumber = SumN(n);
// Console.WriteLine($"Сумма цифр в числе {sumNumber}");

// ____________________________________________________

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int n = InPut("Введите количество элементов в массиве: ");
int m = InPut("Введите максимальное возможное значение элементов массива: ");
Array(n, m);

int InPut(string input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

void Array(int n, int m)
{
    int size = n;
    int[] a = new int[size];
    Console.Write("[");
    for(int i = 0; i < a.Length; i++ )
    {
        a[i] = new Random().Next(0, m);
        if (i < (a.Length - 1))
        {
            Console.Write(a[i] + ", ");
        }
        else
        {
            Console.Write(a[i] + "]");
        } 
    }
}








