
int number1 = new Random().Next(10, 100);
System.Console.WriteLine($"Ваше случайное число 1 равно: {number1}");

int number2 = new Random().Next(10, 100);
System.Console.WriteLine($"Ваше случайное число 2 равно: {number2}");


int DigitCamparison(int number)
{
    
    int digit1 = number / 10;
    int digit2 = number % 10;
    int result = 0;
    if (digit1>digit2)
    {
        result = digit1;
    }
    if (digit1<digit2)
    {
        result = digit2;
    }
    return result;
    
}


// System.Console.WriteLine($"Максимальное число result {DigitComparison}");
// int result = ;
System.Console.WriteLine($"Наибольшая цифра числа 1 равна: {DigitCamparison(number1)}");
System.Console.WriteLine($"Наибольшая цифра числа 2 равна: {DigitCamparison(number2)}");
