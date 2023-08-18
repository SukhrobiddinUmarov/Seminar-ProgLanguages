// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance2D(double Ax, double Ay, double Bx, double By)
{
    double distance = Math.Sqrt(Math.Pow(Ax-Bx, 2) + Math.Pow(Ay-By, 2));
    return Math.Round(distance, 2);
}


System.Console.WriteLine("Введите координату Ax: ");
double Ax = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Ay: ");
double Ay = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Bx: ");
double Bx = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату By: ");
double By = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Расстояние {Distance2D(Ax, Ay, Bx, By)}");