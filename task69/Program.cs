System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int grade = Convert.ToInt32(Console.ReadLine());

int FindGrade(int m, int n)
{
    if (n == 1)
    {
        return m;
    }
    return m * FindGrade(m, n-1);
}

System.Console.WriteLine(FindGrade(number, grade));