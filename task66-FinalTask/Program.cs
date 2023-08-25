// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Введите начальное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите конечное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = number1;

for (int i = number1+1; i <= number2; i++)
{
    sum += i;
}
System.Console.WriteLine(sum);