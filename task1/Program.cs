// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// Console.Write("Введите число - ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень - ");
// int B = int.Parse(Console.ReadLine()!);

int A = new Random().Next(1,10);
int B = new Random().Next(1,10);
Console.WriteLine($"Полученное число - {A}");
Console.WriteLine($"Полученная степень - {B}");



int res = forPow(A, B);
Console.WriteLine($"Число {A} в стпени {B} равно {res}");

int forPow(int num, int pow)
{
    int total = 1;
    for (int i = 1; i <= pow; i++)
    {
        total*= num;
    }
    return total;
}


int result = numInPow(A, B);
Console.WriteLine($"Число {A} в стпени {B} равно {result}");

int numInPow(int num, int pow)
{
    return (int)Math.Pow(num, pow);
}