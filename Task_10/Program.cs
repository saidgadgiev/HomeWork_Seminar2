/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
void SecondNumber(int number)
{
    Console.WriteLine(number/10%10);
}

Console.WriteLine("Введите трехзначное число");
string number_str = Console.ReadLine() ??" "; // Вводим данные
int numberLeng = number_str.Length; // проверяем длину строки
int number;
bool isNumber = int.TryParse(number_str, out number); // проверяет явл введеные данные только цифры

if (isNumber == true) // проверка данных на соответствие если да то
{
    if (numberLeng == 3) // если явл число трехзначным то
    {
        SecondNumber(number);
    }

    else Console.WriteLine("Вы ввели не трехзначное число попробуйте снова"); // если не явл
}

else Console.WriteLine("У вас есть сымволы не являюшиеся цифрами, Вводите только цифры"); // имеются символы не явл цифрами

