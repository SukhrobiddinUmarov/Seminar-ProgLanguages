// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void PrintQuarter(int x, int y)
{
    if (x >0 && y > 0)
    {
        System.Console.WriteLine("Точка располагается в первой четверти");
    }
    if (x <0 && y > 0)
    {
        System.Console.WriteLine("Точка располагается во второй четверти");
    }
    if (x <0 && y < 0)
    {
        System.Console.WriteLine("Точка располагается в третрьей четверти");
    }
    if (x >0 && y < 0)
    {
        System.Console.WriteLine("Точка располагается в четвертой четверти");
    }
}

System.Console.Write("Введите координту Х: ");
int coordinateX = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координту Y: ");
int coordinateY = Convert.ToInt32(Console.ReadLine());

PrintQuarter(coordinateX, coordinateY);