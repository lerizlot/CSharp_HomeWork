// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//d=sqrt(x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2);
/*
double Distance3D(double x1, double y1, double z1,
                 double x2, double y2, double z2)
{
    double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    distance = Math.Round(distance, 2);
    return distance;
}

Console.WriteLine("Input coordinate x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinate x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double answer = Distance3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"The distance is {answer}");


// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeCount(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.Write(count * count * count + " ");
        count++;
    }
}

Console.Write("Task 3. Input your number: ");
int N = Convert.ToInt32(Console.ReadLine());

CubeCount(N);
*/