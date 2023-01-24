// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateDoubleArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);

    return array;
}

void ShowDouble2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Task 1: ");
double[,] myDouble2dArray = CreateDoubleArray();
ShowDouble2dArray(myDouble2dArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

int[,] CreateRandomArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int GetElementByIndex(int[,] array, int x, int y)
{
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == array[x, y])
                number = array[i, j];
    return number;
}

Console.WriteLine("Task 2: ");
int[,] mySecondArray = CreateRandomArray();
ShowArray(mySecondArray);

Console.WriteLine("Input an index of the row: ");
int posX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input an index of the column: ");
int posY = Convert.ToInt32(Console.ReadLine());

int number = GetElementByIndex(mySecondArray, posX, posY);
Console.WriteLine($"Under these indexes located element {number}");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] GetArrayOfAverages(int[,] array)
{
    double[] doubleArray = new double[array.Length];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            doubleArray[j] += array[i, j];
        }
        doubleArray[j] = doubleArray[j] / array.GetLength(0);
    }
    return doubleArray;
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.WriteLine($"The average {i + 1} in the coolumn = {Math.Round(array[i], 2)}  ");
}

Console.WriteLine("Task 3: ");
int[,] myThirdArray = CreateRandomArray();
ShowArray(myThirdArray);
double[] myDoubleArray = GetArrayOfAverages(myThirdArray);
ShowDoubleArray(myDoubleArray);