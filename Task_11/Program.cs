/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
void ThirdNumber(int number);
{
    Console.WriteLine("Yes");
}
Console.WriteLine("Введите любое число - ");
string number_str = Console.ReadLine()??" ";
int numberLeng = number_str.Length;
if (numberLeng > 2)
{
    int number;
    bool isNum = int.TryParse(number_str, out number); // явл все символы цифрами
    if (isNum == true)
    {
        ThirdNumber(number);
    }
    else Console.WriteLine("Не все символы цыфры, введите только цифры");
}
else Console.WriteLine("Третьей цифры нет");