// Задача №47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Задача №47");
Console.WriteLine("Введите m: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int colums = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, colums, -10, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(min-max);
        }    
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j] + " "}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// Задача №50. 
// Напишите программу, которая на вход принимает число, 
// и проверяет есть ли такое число в двумерном массиве, 
// а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
Console.WriteLine("Задача №50");
Console.WriteLine("Введите m: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int colums1 = int.Parse(Console.ReadLine()!);
int[,] array1 = GetArray1(rows1, colums1, 0, 10);
Console.WriteLine("Введите число: ");
int element = int.Parse(Console.ReadLine()!);

PrintArray1(array1);

if(FindElement(array1, element))
{
    Console.WriteLine($"Число {element} найдено");
}
else
{
    Console.WriteLine($"Число {element} не найдено");
}

int[,] GetArray1(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

void PrintArray1(int[,] inarray1)
{
    for(int i = 0; i < inarray1.GetLength(0); i++)
    {
        for(int j = 0; j < inarray1.GetLength(1); j++)
        {
            Console.Write($"{inarray1[i,j]} ");
        }
        Console.WriteLine();
    }
}


bool FindElement(int[,] array1, int element)
{
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j <array1.GetLength(1); j++)
        {
            if(array1[i, j]==element)
            return true; 
        }
    }
    return false;
}


// Задача №52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Задача №52");
Console.WriteLine("Введите m: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int colums2 = int.Parse(Console.ReadLine()!);
int[,] numbers2 = new int[rows2, colums2];
FillArray2(numbers2);
PrintArray2(numbers2);

double[] avgNumbers2 = new double[numbers2.GetLength(1)];

for (int i = 0; i < numbers2.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers2.GetLength(0); j++)
    {
        result += numbers2[j, i];
    }
    avgNumbers2[i] = result / numbers2.GetLength(0);
}
PrintArray3(avgNumbers2);


void FillArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray3(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

