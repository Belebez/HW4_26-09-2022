// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Write("Выберите способ решения 1 - через остаток, 2 - через индекс строки: ");
int way = int.Parse(Console.ReadLine()!);

if (way == 1)
{
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
}
else if (way == 2)
{
    Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
    Console.WriteLine();
    Console.Write("Введите число - ");
    string A = Console.ReadLine()!;

    int res = sumNum(A);
    Console.WriteLine($"Сумма цифр числа {A} равна {res}");

    int sumNum(string num)
    {
        int total = 0;
        int len = num.Length;
        for (int i = 0; i < len; i++)
        {
            int x = (int)char.GetNumericValue(num[i]);  // преобразование символа в число
            total += x;
        }
        return total;
    }
}

else
{
    Console.WriteLine("Вы ввели отличное от 1 или 2 цифру.");
}