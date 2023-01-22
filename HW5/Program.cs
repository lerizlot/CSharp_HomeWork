// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int GetCountEven(int[] newArray)
{
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)
        if (newArray[i] % 2 == 0) count++;
    return count;
}

Console.WriteLine("Task 1: ");

Console.Write("Input a number of elements: ");
int length1 = Convert.ToInt32(Console.ReadLine());
int min1 = 100;
int max1 = 1000;

int[] newArray = CreateRandomArray(length1, min1, max1);
ShowArray(newArray);

Console.WriteLine($"The quantity of even numbers in your array is {GetCountEven(newArray)}");
Console.WriteLine("-----------------");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum = sum + array[i];
        Console.WriteLine($"{sum}");
    return sum;
}

Console.WriteLine("Task 2: ");
Console.Write("Input a number of elements: ");
int length2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[] secondArray = CreateRandomArray(length2, min2, max2);
ShowArray(secondArray);

Console.WriteLine($"The sum of numbers located on the odd position in your array is {GetSumOddPosition(secondArray)}");
Console.WriteLine("-----------------");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
    return array;
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
    Console.WriteLine();
}

double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    double difference = Math.Round(max - min, 2);
    Console.WriteLine($"{max} - {min} = {difference}");
    return difference;
}

Console.WriteLine("Task 3: ");
Console.Write("Input a number of elements: ");
int length3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max3 = Convert.ToInt32(Console.ReadLine());

double[] thirdArray = CreateRandomDoubleArray(length3, min3, max3);
ShowDoubleArray(thirdArray);
Console.WriteLine($"{GetDifference(thirdArray)}");
