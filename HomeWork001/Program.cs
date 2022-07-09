/* Task 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
а какое меньшее.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2) Console.WriteLine("большее число: " + num1 + " меньшее число: " + num2);
if(num1 < num2) Console.WriteLine("меньшее число: " + num1 + " большее число: " + num2);
*/

/* Task 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;    

Console.WriteLine("Max = " + max);
*/


/* Task 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0) Console.WriteLine("четное: " + num);
else Console.WriteLine("нечетное: " + num);
*/


// Task 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные 
//числа от 1 до N.

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= num)
    {
    Console.Write(current + " ");
    current = current +2;
    }