System.Console.Write("Введите количество строк: ");
int colQuantity = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int rowQuantity = Convert.ToInt32(Console.ReadLine());
int[,] Array = new int[colQuantity, rowQuantity];
System.Console.Write("Введите максимальное значение цифр в массиве: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, maxNum+1);
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

void CountMatrix(int[,] arr)
{
    int[] MatrixCount = new int[maxNum];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            MatrixCount[arr[i, j]-1]++;
        }
    }

    for (int i = 0; i < MatrixCount.GetLength(0); i++)
    {
        if (MatrixCount[i] > 0)
        {
            System.Console.WriteLine($"{i+1} встречается {MatrixCount[i]} раз");
        }
    }
}


FillArray(Array);
PrintArray(Array);
CountMatrix(Array);
