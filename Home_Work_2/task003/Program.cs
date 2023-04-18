// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели,
// и проверяет, является ли этот день выходным

//Input
Console.Write("Введите номер дня недели ");
string nubmerDay = Console.ReadLine() ?? "";

//Logic
int weekDay = int.Parse(nubmerDay);

if (weekDay <= 5 && weekDay == 1 && weekDay == 2 && weekDay == 3 && weekDay==4);
    Console.Write("Будний день");
if (weekDay > 5 && weekDay == 6)
    Console.Write("УРА! Суббота, выходной день");
if (weekDay > 5 && weekDay == 7)
    Console.Write("УРА! Воскресенье, выходной день");
if (weekDay > 7)
    Console.Write("Такого дня недели не существует");