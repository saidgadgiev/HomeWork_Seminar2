/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
void ThirdNumber(int number, int numberLeng)
{
    double ThirdNumber = Math.Pow(10, numberLeng-3);
    int numberRes = Convert.ToInt32(ThirdNumber);
    int resultat = number / numberRes % 10;

    Console.WriteLine(resultat);
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
        ThirdNumber(number, numberLeng);
    }
    else 
    {
        Console.WriteLine("Не все символы цыфры или ввели число больше 2147483647,");
        Console.WriteLine("введите только цифры или число менше 2147483648");
    }
}
else Console.WriteLine("Третьей цифры нет");