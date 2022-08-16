//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] FillArray(int i, int j, int minValue, int maxValue)
{
    double[,] matrix = new double[i, j];

    for(i = 0; i < matrix.GetLength(0); i++)
    {
        for(j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1) + Math.Round (new Random().NextDouble(),1);
        }       
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
    Console.WriteLine();        
    }
}

Console.Write("Input size of array n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size of array m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minVal: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxVal: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

double[,] matr = FillArray(n, m, minVal, maxVal);
Console.WriteLine();
PrintArray(matr);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillArray(int i, int j, int minValue, int maxValue)
{
    int[,] matrix = new int[i, j];

    for(i = 0; i < matrix.GetLength(0); i++)
    {
        for(j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
        }       
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();        
    }
}

void FindArray(int[,] matrix, int k, int l)
{
    if(matrix.GetLength(0) <= k || matrix.GetLength(1) <= l) 
    {
        Console.Write($"Тhe matrix element with the position matrix[{k}, {l}] does not exist");
    }
        
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if(i == k && j == l) Console.Write($"Еlement value: {matrix[i, j]}");
            }              
        }
    
}

Console.Write("Input size of array i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size of array j: ");
int j = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the item position i: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the item position j: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,] matr = FillArray(i, j, minVal, maxVal);
Console.WriteLine();
PrintArray(matr);
Console.WriteLine();
FindArray(matr, k, l);


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] FillArray(int i, int j, int minValue, int maxValue)
{
    int[,] matrix = new int[i, j];

    for(i = 0; i < matrix.GetLength(0); i++)
    {
        for(j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
        }       
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();        
    }
}

void ArithmeticMean(int[,] matrix)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        double arithmeticMean = Math.Round((sum / matrix.GetLength(0)),1);
        Console.Write(arithmeticMean + "  "); 
    }
}

Console.Write("Input size of array i: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size of array j: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[,] matr = FillArray(n, m, minVal, maxVal);
Console.WriteLine();
PrintArray(matr);
Console.WriteLine();
ArithmeticMean(matr);
*/