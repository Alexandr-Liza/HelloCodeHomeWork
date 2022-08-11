
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string s; 
int i = 0; 
int count = 0;

Console.WriteLine("Input the numbers, after each press <Enter>, to finish, press 2 times <Enter>");

while(true) 
{ 
    s = Console.ReadLine(); 
    if(s == string.Empty) 
    { 
        Console.WriteLine($"The program is completed! Number of positive numbers {count}.");
        break; 
    } 
    else 
    { 
        i = Convert.ToInt32(s);
        if(i > 0)
        {
            count++;
            Console.WriteLine($"The entered positive number {i} Number of positive numbers {count}.");
        }
        else 
        Console.WriteLine($"The entered negative number {i}");
    } 
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
double IntersectionX(double B1, double K1, double B2, double K2)
{
    double X = (B2 - B1) / (K1 - K2); return X;
    
    //Y = K1 * X + B1;
    //Y = K2 * X + B2;
    //K1 * X + B1 = K2 * X + B2;
    //K1 * X - K2 * X = B2 - B1
    //X (K1 - K2) = B2 - B1
    //X = (B2 - B1) / (K1 - K2)
}

Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = IntersectionX(b1, k1, b2, k2);
double y = (k1 * x) + b1;
double y1 = (k2 * x) + b2; // проверка

Console.WriteLine($"Intersection: x = {x}, y = {y}");
Console.Write($"Сheckout: y = {y}, y1 = {y1}");
*/