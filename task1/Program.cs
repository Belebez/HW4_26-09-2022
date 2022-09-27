// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Программа возводит число A в натуральную степень B");
Console.WriteLine();
Console.Write("Выберите способ решения, введите 1 или 2 --> ");
int solutionOption = int.Parse(Console.ReadLine()!);

if (solutionOption == 1)
{
    Console.WriteLine("Решение через цикл for. С ручным вводом цифр.");
    Console.WriteLine();
    Console.Write("Введите число - ");
    int A = int.Parse(Console.ReadLine()!);
    Console.Write("Введите степень - ");
    int B = int.Parse(Console.ReadLine()!);

    int res = forPow(A, B);
    Console.WriteLine($"Число {A} в степени {B} равно {res}");

    int forPow(int num, int pow)
    {
        int total = 1;
        for (int i = 1; i <= pow; i++)
        {
            total*= num;
        }
        return total;
    }
}

else if (solutionOption == 2)
{
    Console.WriteLine("Решение через Math.Pow(). Цифры получаем случайным образом.");
    Console.WriteLine();
    int A = new Random().Next(1,10);
    int B = new Random().Next(1,10);
    Console.WriteLine($"Полученное число - {A}");
    Console.WriteLine($"Полученная степень - {B}");

    int result = numInPow(A, B);
    Console.WriteLine($"Число {A} в степени {B} равно {result}");

    int numInPow(int num, int pow)
    {
        return (int)Math.Pow(num, pow);
    }
}

else
{
    Console.WriteLine("Вы ввели отличную от 1 или 2 цифру");
}