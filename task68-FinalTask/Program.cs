// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.Write("Введите значение m: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение n: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n +1;
    }
    if (m > 0 && n == 0)
    {
        return AckermannFunction(m-1, 1);
    }
    return AckermannFunction(m-1, AckermannFunction(m, n-1));
}

System.Console.WriteLine(AckermannFunction(number1, number2));