﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (i = 2; i <= num; i += 2)
{
        Console.Write($"{i}, ");
}








Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
for (i = 2; i <= num; i += 2)
{
        Console.Write($"{i}, ");
}