// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int[] array = Auto();
int[] Auto()
{
    int[] array;
    array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {

        System.Console.WriteLine($"Введите значение элемента массива индекса {i}");
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
    return array;
}
System.Console.WriteLine(string.Join(" | ", array));