// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

System.Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[arrayLength];
System.Console.Write("Введите минимальное значение искомого диапазона: ");
int checkingMinNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное значение искомого диапазона: ");
int checkingMaxNumber = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-9, 123);
}
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.Write($"Массив содержит следующие значения: ");
    System.Console.Write(string.Join("; ", arr));
    System.Console.WriteLine();
    
}

void PrintRange(int[] arr, int minNumber, int maxNumber)
{
    int quantity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if (arr[i]  >= minNumber && arr[i] <= maxNumber)
        {
            quantity++;
        }
    }
    if (quantity == 0)
    {
        System.Console.Write($"Массив не содержит элемент {quantity}");
    }
    else
    {
    System.Console.Write($"Массив содержит {quantity} ");
    switch(quantity)
        {
            case 1:
                Console.Write("элемент");
                break;
            case 2:
                Console.Write("элемента");
                break;
            case 3:
                Console.Write("элемента");
                break;
            case 4:
                Console.Write("элемента");
                break;
            default:
                Console.Write("элементов");
                break;
        }
    System.Console.Write($" в отрезке от {minNumber} по {maxNumber}");
    }
}

FillArray(Array);
PrintArray(Array);
PrintRange(Array, checkingMinNumber, checkingMaxNumber);
