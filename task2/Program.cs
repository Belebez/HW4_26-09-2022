// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine();
Console.Write("Введите число - ");
int A = int.Parse(Console.ReadLine()!);

int res = sumNum(A);
Console.WriteLine($"Сумма цифр числа {A} равна {res}");

int sumNum(int num)
{
    int total = 0;
    int len = (int)Math.Log10(num) + 1;
    for (int i = 1; i <= len; i++)
    {
        int lastNum = num % 10;
        total += lastNum;
        num /= 10;
    }
    return total;
}
