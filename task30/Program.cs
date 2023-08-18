// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
System.Console.Write("Введите количество массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[arrayLength];

for (int count = 0; count < arr.Length; count++)
{
    arr[count] = new Random().Next(0, 2);
}


System.Console.WriteLine($"[{string.Join(";", arr)}]");
