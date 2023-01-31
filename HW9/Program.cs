// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNumbers(n - 1);
}

Console.WriteLine("Task 1: ");
Console.WriteLine("Input the number n: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sum = 0;

void GetSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Sum of the elements from m to n = {sum} ");
        return;
    }
    GetSum(m, n - 1, sum);
}

Console.WriteLine("");
Console.WriteLine("Task 2: ");
Console.WriteLine("Input the number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number n: ");
int n2 = Convert.ToInt32(Console.ReadLine());
GetSum(m, n2, sum);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.WriteLine("");
Console.WriteLine("Task 3: ");
Console.WriteLine(AkkermanFunc(2, 3));
Console.WriteLine(AkkermanFunc(3, 2));

