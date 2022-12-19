// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNumber(int number)
{
    int actionOne = number % 100; // 56
    int actionTwo = actionOne / 10; // 5

    return actionTwo;
}
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecondNumber(num);

if (num <= 999 && num >= 100)
    Console.WriteLine($"The second number is {result}");
else
    Console.WriteLine("Your number is wrong. Please input a three-digit number.");
    
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
