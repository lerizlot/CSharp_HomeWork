//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Exponentiate(int A, int B)
{
    int result = A;
    while(B > 1)
    {
        result = result*A;
        Console.WriteLine(result);
        B--;
    }
    return result;
}

Console.WriteLine("Task 1: Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int answer = Exponentiate(a, b);
Console.WriteLine($"The answer is {answer}");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        int num = number % 10;
        number = number / 10;
        sum = sum + num;
    }
    return sum;
}

Console.WriteLine("Task 2: Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
int answer2 = Sum(num);
Console.WriteLine($"The sum of all the numbers in your number is {answer2}");

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetElements()
{
    int element = Convert.ToInt32(Console.ReadLine());
    return element;
    //Console.Write(element);
}

int[] CreateRandomArray(int m)
{
    int[] array = new int[m];

    for(int i = 0; i < m; i++)
        array[i] = GetElements();

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "," + " ");
    
    Console.WriteLine();
}

Console.Write("Task 3: Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your numbers: ");

int[] newArray = CreateRandomArray(m);
Console.Write("Your array is: ");
ShowArray(newArray);
