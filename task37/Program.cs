// // Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

System.Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[arrayLength];

int[] FillArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 100);
}
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.Write($"Массив содержит следующие значения: ");
    System.Console.Write(string.Join("; ", arr));
    System.Console.WriteLine();
    System.Console.WriteLine();
    
}

int[] MultiplyPairs(int[] arr)
{
    int newLen = arr.Length / 2 + (arr.Length % 2);
    // if (arr.Length % 2 != 0)
    // {
    //     len = arr.Length / 2 + 1;
    // }
    int[] MulpliedPairsArray = new int[newLen];

    for (int i = 0; i < arr.Length / 2; i++)
    {
    MulpliedPairsArray[i] = arr[i] * arr[(arr.Length - 1) - i];
    //System.Console.Write($"{arr[i] * arr[(arr.Length - 1) - i]}; ");
    }

    if (arr.Length % 2 != 0)
    {
        MulpliedPairsArray[(arr.Length-1) / 2] = arr[(arr.Length) / 2];
    }
    return MulpliedPairsArray;
}

void PrintMulpliedPairsArray(int[] arr)
{
    System.Console.Write("Произведение пар чисел равно: ");
    System.Console.Write(string.Join("; ", arr));
    System.Console.WriteLine();
    
}

FillArray(Array);
PrintArray(Array);
PrintMulpliedPairsArray(MultiplyPairs(Array));
