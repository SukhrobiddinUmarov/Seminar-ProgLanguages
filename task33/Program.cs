// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

System.Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[arrayLength];
System.Console.Write("Введите искомое значение: ");
int checkingNumber = Convert.ToInt32(Console.ReadLine());

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

bool CheckNumber(int[] arr, int checkNumber)
{
        for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == checkNumber)
        {
            return true;
        }
    }
    return false;
}



FillArray(Array);
PrintArray(Array);
// CheckNumber(Array, checkingNumber);

