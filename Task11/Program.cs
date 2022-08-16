// Задача 20
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1), -> 5.09

Console.WriteLine("Введите x для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance (int xa, int ya, int xb, int yb)
{
    return Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya));
}
double result = Distance (x1, y1, x2, y2);

Console.WriteLine($"A({x1}, {y1}), B({x2}, {y2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");




// double distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
// Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));