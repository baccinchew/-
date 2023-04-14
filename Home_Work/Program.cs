/* Написать программу, которая на вход
принимает два числа и выдаёт, какое число большее,
а какое меньшее.
a=5; b=7; -> max=7
a=2; b=10; -> max=10
a=-9; b=-3; -> max=-3


//Input
Console.Write("Введите первое число: ");
string input1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string input2 = Console.ReadLine() ?? "";
//Logic
int a = int.Parse(input1);
int b = int.Parse(input2);
int max = a;
if (b > max) 
{
    Console.WriteLine(max = b);
}
//Output
Console.Write($"{a};{b};->{max}");
*/


/*
Написать программу, которая на вход
принимает три числа и выдёт максимальное
из этих чисел:
2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22
*/
/*
//Input
Console.Write("Введите первое число: ");
string input1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string input2 = Console.ReadLine() ?? "";
Console.Write("Введите третье число: ");
string input3 = Console.ReadLine() ?? "";
//Logic
int a = int.Parse(input1);
int b = int.Parse(input2);
int c = int.Parse(input3);
int max = 0;
if (a > max) max=a;
if (b > max) max=b;
if (c > max) max=c;
//Output
Console.Write($"{a};{b};{c}->{max}");
*/

/* Написать программу, которая на вход
принимает число и выдает, является ли число
чётным(делится ли оно на два без остатка)
4 -> yes
-3 -> no
7 -> no


//Input
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
//Logic
int a = int.Parse(userInput);
if (a%2 == 0)
{
    Console.Write("Число является четным!");
}
else
{
    Console.Write("Число не явяется четным!");
}
*/


/*
Напишите программу, которая на вход
принимает число (N), а на выходе показывает
все чётные числа от 1 до N
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

//Input
Console.WriteLine("Введите число: ");
string N = Console.ReadLine() ?? "";
//Logic
int a = int.Parse(N);
for (int i = 1; i <= a; i++)
{
    if (i % 2 == 0)
        Console.Write($" {i} ");
}