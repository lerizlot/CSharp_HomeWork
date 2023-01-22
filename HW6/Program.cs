// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

int CountPositive(int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input number {i + 1}: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) count++;
    }
    return count;
}

Console.WriteLine("Task 1:");

Console.Write("Input quantity of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"The quantity of positive numbers is {CountPositive(size)}");
Console.WriteLine("---------");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double CrossPointX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double CrossPointY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.WriteLine("Task 2:");
Console.Write("Enter the value k1 for line 1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the value b1 for line 1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the value k2 for line 2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the value b2 for line 2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = CrossPointX(k1, b1, k2, b2);
double y = CrossPointY(k1, b1, x);
Console.WriteLine($"Coordinates of the intersection point of two straight lines = ({x};{y})");
