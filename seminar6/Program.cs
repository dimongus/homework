// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// int[] array = CreateRandomArray(3);

// Console.WriteLine(string.Join(",",array));
// Console.WriteLine(FindCount(array));


// int[] CreateRandomArray(int size)
// {
//     Random random = new Random();
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }


// int FindCount(int[]array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)count++;
//     }
//     return count;
// }

//_____________________________________________________________________________________________\


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


/*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Для создания рандома я использую предыдущию запись!!!!!!!!!!!!!!!!!!!!!!!!!!! */

// Console.WriteLine("enter the number of array elementsy");
// int n =int.Parse(Console.ReadLine());

// //int[] array = new int[]{-4, -6, 89, 6};
// int []array =CreateRandomArray(n);
// Console.WriteLine(string.Join(",", array));
// Console.WriteLine(SumElementOddNumb(array));


// int SumElementOddNumb(int[] array)
// {
//     int sumOdd = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 0)
//             sumOdd = sumOdd + array[i];
//     }
//     return sumOdd;
// }


//____________________________________________________________


// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



Console.WriteLine("Введите число массива");
int n = int.Parse(Console.ReadLine());
int[] array = CreateRandomArray(n);
int max = MaxNum(array);
int min = MinNum(array);

Console.WriteLine(string.Join(",", array));
Console.WriteLine("Разница максимального и минимального:  " + (max - min));



int[] CreateRandomArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
    return array;
}


int MaxNum(int[] array)
{
    int MaxN = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (MaxN < array[i]) MaxN = array[i];
    }
    return MaxN;
}

int MinNum(int[] array)
{
    int MinN = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (MinN > array[i])
            MinN = array[i];
    }
    return MinN;
}
