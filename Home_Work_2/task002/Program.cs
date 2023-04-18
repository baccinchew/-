// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
//input
Console.WriteLine("Введите число: ");
string userInput = Console.ReadLine() ?? "";
//Logic
var a = int.Parse(userInput);
if (a < 100)
{
    Console.WriteLine("Третьей цифры числа не существует!");
}
else if (a > 999)
{
    var b = a / 10 % 10;
    Console.Write($"Третья цифра числа -> {b}");
}
else if (a>10000)
{
    var b1 = a / 100 % 100;
    Console.Write($"Третья цифра заданного числа ={b1}");
}