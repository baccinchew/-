/* Написать программу, которая принимает на вход
трехзначное число и на выходе показывает вторую 
цифру этого числа
*/
Console.Clear();
//Input
Console.Write("Введите любое трёхзначное число: ");
string input = Console.ReadLine() ?? "";
//Logic
var a = int.Parse(input);
var b = a % 100;
var c = b / 10;
Console.Write($"{a}->{c}");
