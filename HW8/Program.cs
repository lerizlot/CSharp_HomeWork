// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateRandom2dArray()
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

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ArrangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
    return array;
}

Console.WriteLine("Task 1: ");
int[,] firstArray = CreateRandom2dArray();
Show2dArray(firstArray);
Show2dArray(ArrangeArray(firstArray));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int RowWithMinSum(int[,] array)
{
    int row = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if (i == 0) result = sum;
        else if (sum < result)
        {
            result = sum;
            row = i;
        }
    }
    return row;
}

Console.WriteLine("Task 2: ");
int[,] secondArray = CreateRandom2dArray();
Show2dArray(secondArray);
int row = RowWithMinSum(secondArray);
Console.WriteLine($"The row with the smallest sum of elements is the row № {row}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

int[,] ProductOfTwoArrays(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            newArray[i, j] = array1[i, j] * array2[i, j];
        }

    return newArray;
}

Console.WriteLine("");
Console.WriteLine("Task 3: ");

Console.WriteLine("Please enter the data for the first array: ");
int[,] myArray1 = CreateRandom2dArray();

Console.WriteLine("Enter the data for the second array. Please note that the number of rows and columns must be the same for both arrays: ");
int[,] myArray2 = CreateRandom2dArray();
Console.WriteLine("");

Console.WriteLine("First array: ");
Show2dArray(myArray1);
Console.WriteLine("Second array: ");
Show2dArray(myArray2);

int[,] newArray = ProductOfTwoArrays(myArray1, myArray2);
Console.WriteLine("The product of two arrays: ");
Show2dArray(newArray);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Task 4: ");
Console.Write("Input a X of 3D matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Y of 3D matrix: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Z of 3D matrix: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = new int[x, y, z];

void CreateRandom3dArray(int[,,] array3D)
{
    int[] array = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 100);
        number = array[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 100);
                    j = 0;
                    number = array[i];
                }
                number = array[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = array[count];
                count++;
            }
        }
    }
}

void Show3dArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
        }
    }
    Console.WriteLine();
}

CreateRandom3dArray(array3D);
Show3dArray(array3D);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralArray()
{
    Console.Write("Input a size of array: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[size, size];
    int num = 1;
    int minRow = 0;
    int maxRow = size - 1;
    int minCol = 0;
    int maxCol = size - 1;
    while (num <= array.GetLength(0) * array.GetLength(1))
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            array[minCol, i] = num;
            num++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++)
        {
            array[i, maxCol] = num;
            num++;
        }
        maxCol--;
        for (int i = maxCol; i >= minCol; i--)
        {
            array[maxRow, i] = num;
            num++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow; i--)
        {
            array[i, minCol] = num;
            num++;
        }
        minCol++;
    }
    return array;
}

Console.WriteLine("Task 5: ");
int[,] forthArray = SpiralArray();
Show2dArray(forthArray);