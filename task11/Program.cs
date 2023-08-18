// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

int firstNumber = number / 100;
int lastNumber = number % 10;
int result = firstNumber * 10 + lastNumber;


System.Console.WriteLine($"Ваше случайное число: {number}");
System.Console.WriteLine($"Первая и последлная цифра равна {result}");
