// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Решение через метод Math.Abs (c отрицательными числами)


Console.Write("Input number from 100: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) {number = number * -1;}
number = Math.Abs(number);
int middle = (number / 10) % 10;
Console.WriteLine(middle);

