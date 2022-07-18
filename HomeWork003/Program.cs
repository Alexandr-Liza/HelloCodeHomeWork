//Task 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно 
//палиндромом.

bool Polydrome(int number)
{
    if(number / 10000 == number % 10)
    {
        if (number / 1000 % 10 == number % 100 / 10)
            return true;
        else return false;
    }
    else return false;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool poi = Polydrome(num);

Console.WriteLine($"Polydrome: {poi}");


//Task 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
/*
double Pithagoras(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    double distance = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1) + (Z2 - Z1) * (Z2 - Z1));
    return distance;
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double dist = Pithagoras(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"The distance between the coordinates of two points: {dist}");
*/


//Task 3: Напишите программу, которая принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cubed(int number)
{
int current = 1;

    while(current <= number)
        {
        int result = current * current * current;
        Console.Write(" " + result + ",");
        current++;
        }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num != 0)
{
    if(num < 0)
    {
        num = num * (-1);
        Cubed(num);
    }
    else Cubed(num);
}
else Console.Write("Uncorrect input!");
*/