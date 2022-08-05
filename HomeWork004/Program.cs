//Task 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
//степень B.
/*
int DegreeOfNumber(int number, int degree)
{
    int count = 1;
    int index = number;

    while(count < degree)
    {
        number = number * index;
        count++;
    }
    return number;
} 

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Input degree: ");
int degr = Convert.ToInt32(Console.ReadLine());

int DegrOfNum = DegreeOfNumber(num, degr);

Console.WriteLine($"Degree of number: {DegrOfNum}");
*/

//Task 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfNumbers(int number)
{
int sum = 0;

    if(number < 0) number = number * (-1);

        while(number > 0)
        {
            int count = number % 10;
            number = number / 10;
            sum = sum + count;   
        }
        return sum;   
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int summa = SumOfNumbers(num);

Console.WriteLine($"Sum of numbers: {summa}");
*/

//Task 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] EnterAnArrayElement(int size)
{   
    int[] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i} element of the array: ");
        int num = Convert.ToInt32(Console.ReadLine());
        newArray[i] = num;
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)

        Console.Write(array[i] + ", ");
}

int[] ArrayElement = EnterAnArrayElement(8);
ShowArray(ArrayElement);
