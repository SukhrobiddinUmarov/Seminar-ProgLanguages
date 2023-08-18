// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


System.Console.Write("Введите номер четверти: ");
int quaterNumber = Convert.ToInt32(Console.ReadLine());
string[] quaters = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0"};

System.Console.WriteLine($"{quaters[quaterNumber-1]}");
