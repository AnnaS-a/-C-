// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
  Console.Write("Сегодня понедельник");
}
else if (a == 2)
{
 Console.Write("Сегодня вторник");
}
else if (a == 3)
{
 Console.Write("Сегодня среда");
}
else if (a == 4)
{
 Console.Write("Сегодня четверг");
}
else if (a == 5)
{
 Console.Write("Сегодня пятница");
}
else if (a == 6)
{
 Console.Write("Сегодня суббота");
}
else if (a == 7)
{
 Console.Write("Сегодня воскресенье");
}
else
{
  Console.Write("Некорректный ввод");  
}