// Напишите программу, которая по заданному номеру четверти показывает диапозон возможных координат точек в этой четверти (Х и У)


Console.WriteLine("Введите номер четверти ");
int num = Convert.ToInt32(Console.ReadLine());

string Coordinat(int number)
{
    if (number == 1) return "Диапозон координат х > 0, y > 0";
    if (number == 2) return "Диапозон координат х < 0, y > 0";
    if (number == 3) return "Диапозон координат х < 0, y < 0";
    if (number == 4) return "Диапозон координат х > 0, y < 0";
    return "Введен некорректный номер четверти";
}

string result = Coordinat(num);
Console.WriteLine(result);
