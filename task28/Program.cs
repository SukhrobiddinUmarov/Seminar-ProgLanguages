// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int Multiply(int num)
{
    int multiply = 1;
    for (int i = 1; i <= num; i++)
    {
        multiply = multiply * i;
    }
    return multiply;
}

System.Console.WriteLine(Multiply(number));
