//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке
// от M до N.

void ShowNumbers(int m, int n)
{
    if(n > m)
    {
        int temp = n;
        n = m;
        m = temp;
    }
   
    if(n <= m)
    {
        if(m != n) ShowNumbers(n, m-1);
        Console.Write(m + " ");
    } 
}       

Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNumbers(m, n);


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
/*
int SumOfElements(int m, int n)
{
    if(m > n) 
    if(m != n) return n + SumOfElements(m, n + 1);
    return m;
}

Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m < n)
{
    int temp = n;
    n = m;
    m = temp;
}

Console.Write($"Sum of elements from {m} to {n}: {SumOfElements(m, n)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AckermanFunction(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return AckermanFunction(m - 1,1);
    if(m > 0 && n > 0) return AckermanFunction(m - 1,AckermanFunction(m,n - 1));
    return 0;
}

Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Ackerman function: M = {m}, N = {n}, Ackerman {AckermanFunction(m, n)}");
*/