/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введити цифру от 1 до 7 - ");
string numStr = Console.ReadLine()??" ";
Console.WriteLine("");
//int num = Convert.ToInt32(numStr);
string [] mass = {"Понидельник", "Вторник", "Среда", 
                "Четверг", "Пятница", "Суббота", "воскресенье"};
int num;
bool isNum = int.TryParse(numStr, out num);
if (isNum == true)
{ 
    if (num < 8 && num > 0)
    {
        if (num < 6)
        {
            Console.WriteLine($"Сегодня {num} день недели. Это {mass[num-1]} значит РАБОЧИЙ день");
        }
        else Console.WriteLine($"Сегодня {num} день недели. Это {mass[num-1]} значит ВЫХОДНОЙ");
    }
    else 
    {
        Console.WriteLine("Вы ввели не допустимую цифру");
        Console.WriteLine("Введити цифру от 1 до 7");
    }
}
Console.WriteLine("Вы ввели не цифру. Введити цифру от 1 до 7");

