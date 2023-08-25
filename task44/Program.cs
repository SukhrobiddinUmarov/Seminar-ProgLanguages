System.Console.Write("Введите число Фибоначи: ");
int fibNumber = Convert.ToInt32(Console.ReadLine());


int[] FibonacciNumbers(int number)
{
                
    int[] fibonacciNumbers = new int[number];
    if (fibNumber == 1)
    {
        fibonacciNumbers[0] = 0;
        return fibonacciNumbers;
    }
    else
    {
        
        fibonacciNumbers[1] = 1;
        for (int i = 2; i < number; i++)
        {
            fibonacciNumbers[i] = fibonacciNumbers[i-1] + fibonacciNumbers[i-2];
        }
        return fibonacciNumbers;
    }
}


System.Console.WriteLine(string.Join(", ", FibonacciNumbers(fibNumber)));