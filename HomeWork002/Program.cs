/* Task 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.

int SecondDigit(int number)
{
    int dec = number / 10 % 10;
    return dec;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(num);

Console.Write($"SecondDigit {result}");
*/

// Task 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей 
//цифры нет.

int ThreeDigit(int number)
{
    while(number > 999) number = number / 10;
    return number;
}

int TheThird(int n)
{
    n = n % 10 % 10;
    int res = n;
    return n;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 100)
{
    int three = ThreeDigit(num);
    int third = TheThird(three);

    Console.WriteLine($"Third digit {third}");
}

else Console.WriteLine("Third digit No");



/* Task 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

bool Weekend(int number)
{
    if(number > 5 && number < 8) return true;
    else return false;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool poi = Weekend(num);

Console.WriteLine($"Weekend {poi}");
*/