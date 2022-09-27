// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


Console.WriteLine("Программа, которая задаёт массив из N элементов и выводит их на экран.");
Console.WriteLine();

int A = new Random().Next(2, 21);
Console.WriteLine($"Размер массива равен {A}");

int[] array = fillArray(A);
Console.WriteLine($"Полученный массив - [{String.Join(",", array)}]");

int[] fillArray(int size)
{
    int[] result = new int[size];
    for (int i = 1; i < size; i++)
    {
        result[i] = new Random().Next(0,100);
    }
    return result;
}