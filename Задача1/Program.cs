﻿// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Input number from 100: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Eror");
}
else
{
    for(; number > 999;) {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}