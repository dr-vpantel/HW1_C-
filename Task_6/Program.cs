﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int DivRem = number % 2;
if (DivRem == 0)
{
    Console.WriteLine("Да, число четное");
}
else
{
    Console.WriteLine("Нет, число нечетное");
}