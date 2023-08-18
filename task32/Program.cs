// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


System.Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[arrayLength];

int[] FillArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-9, 10);
}
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.Write($"Массив содержит следующие значения: ");
    System.Console.Write(string.Join("; ", arr));
    System.Console.WriteLine();
    
}

int[] ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}

FillArray(Array);
PrintArray(Array);
ReverseArray(Array);
PrintArray(Array);