﻿// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Sum(int num)
{
int sum = 0;

for (int i = 1; i <= number; i++)
{
    sum = sum + i;
}
System.Console.WriteLine(sum);
}

Sum(number);
