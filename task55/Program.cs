System.Console.Write("Введите количество строк: ");
int colQuantity = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int rowQuantity = Convert.ToInt32(Console.ReadLine());
int[,] Array = new int[colQuantity, rowQuantity];

int[,] FillArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 100);
    }
    
}
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] ChangeArray(int[,] arr)
{
int[,] newArray = new int[arr.GetLength(1), arr.GetLength(0)];

for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        newArray[i, j] = arr[j, i];
    }
    
}
    return newArray;
}

FillArray(Array);
PrintArray(Array);
PrintArray(ChangeArray(Array));
PrintArray(Array);