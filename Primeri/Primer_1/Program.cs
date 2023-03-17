//  Задайте значения M и N. Напишите программу, которая выведет
//  все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
NaturalToLow(m, n);

void NaturalToLow(int m, int n)
{
    if (m > n)
    {
        return;
    }
    else
    {
        NaturalToLow( m + 1, n);
        Console.Write($"{m}" + " ");
    }
}
