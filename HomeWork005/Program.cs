// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    int minValue = 100;
    int maxValue = 1000;
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue); 
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;

    return count;
}


Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size);
ShowArray(array);
int evenNumbers = EvenNumbers(array);

Console.Write($"Even numbers: {evenNumbers}");


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOfNonEvenNumbers(int[] array)
{
    int i = 1;
    int summa = 0;
    while(i < array.Length)
    {
        summa = summa + array[i];
        i = i + 2;
    }
    return summa;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int sumOfNonEvenNumbers = SumOfNonEvenNumbers(array);

Console.Write($"The sum of non-even array elements: {sumOfNonEvenNumbers}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом
// массива.
/*
int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i + 1} element of the array is {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int MaximumElement(int[] array)
{
    int i = 0;
    int max = array[i];
    for(i = 1; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }  
    return max;
}

int MinimumElement(int[] array)
{
    int i = 0;
    int min = array[i];
    for(i = 1; i < array.Length; i++)
        if(array[i] < min) min = array[i];
    return min;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);
Console.WriteLine();
ShowArray(array);
Console.WriteLine();
int maximumElement = MaximumElement(array);
int minimumElement = MinimumElement(array);

int result = maximumElement - minimumElement;

Console.Write($"Maximum element: {maximumElement}");
Console.WriteLine();
Console.Write($"Minimum element: {minimumElement}");
Console.WriteLine();
Console.Write($"Result: {result}");
*/