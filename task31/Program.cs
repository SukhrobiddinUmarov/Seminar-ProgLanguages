// Задача 31: Задайте массив из N элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

System.Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[arrayLength];

int[] FillArray(int[] arr, int arrLength)
{
for (int i = 0; i < arrLength; i++)
{
    arr[i] = new Random().Next(-9, 10);
}
    return arr;
}

void PrintArray(int[] arr, int arrLength)
{
    System.Console.Write($"Массив содержит следующие значения: ");
    System.Console.Write(string.Join("; ", arr));
    System.Console.WriteLine();
    
}

void SumNum(int[] arr, int arrLength)
{
    int posNum = 0;
    int negNum = 0;
    for (int i = 0; i < arrLength; i++)
    {
        if (arr[i] > 0)
        {
            posNum = posNum + arr[i];
        }
        if (arr[i] < 0)
        {
            negNum = negNum + arr[i];
        }
    }
    System.Console.WriteLine($"Сумма положительных цифр равна {posNum}.");
    System.Console.WriteLine($"Сумма отрицательных цифр равна {negNum}.");
}

FillArray(Array, arrayLength);
PrintArray(Array, arrayLength);
SumNum(Array, arrayLength);