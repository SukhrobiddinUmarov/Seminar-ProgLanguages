// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
void GetBinaryNum(int num)
{
    if (num == 0)
    {
        return;
    }
    
    GetBinaryNum(num/2);
    System.Console.Write(num%2);
}


GetBinaryNum(number);