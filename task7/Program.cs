void NumberEntry()
    {
        Console.WriteLine("Введите число!");
        string entry = Console.ReadLine();
        int number = Convert.ToInt32(entry);
        if(number < 100 || number > 1000)
            {
                Console.WriteLine("Введенное число не трехзначное!");
                NumberEntry();
            }
        int result = number % 10;
        Console.WriteLine($"{result}");
        
}

NumberEntry();