/*
Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
    return;
}

int remain = 0;
int reversNumber = 0;

while (number > 0)
{
    remain = number % 10;
    reversNumber = reversNumber * 10 + remain;
    number /= 10;
}

int thirdDigit = reversNumber / 100 % 10;

System.Console.WriteLine($"Третья цифра: {thirdDigit}");