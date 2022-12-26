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