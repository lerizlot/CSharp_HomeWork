// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNumber(int number)
{
    int count = number % 100 / 10;
    return count;
}
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

int secondNumber = SecondNumber(num);

// необязательная по условию задачи проверка на 3-х значность
if (num <= 999 && num >= 100)
    Console.WriteLine($"The second number is {secondNumber}");
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

bool DayOfTheWeek (int numb)
{
    if (numb == 6 || numb == 7) return true;
    else return false;
}

Console.Write("Input your number: ");
int numb = Convert.ToInt32(Console.ReadLine());

bool result = DayOfTheWeek(numb);

Console.WriteLine($"The number you entered is a weekend: {result}");
