/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите любое число - ");
string number_str = Console.ReadLine()??" ";
int numberLeng = number_str.Length;
if (numberLeng < 3)
Console.WriteLine(numberLeng);