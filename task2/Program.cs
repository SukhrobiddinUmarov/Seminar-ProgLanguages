void DayNumberEntry()
    {
        Console.WriteLine("Введите номер дня недели!");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Неправильный номер дня недели!");
                    DayNumberEntry();
                    break;
            }
    }

DayNumberEntry();