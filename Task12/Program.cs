// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("  x    x**3 ");

void PrintCube(int b)
{
    for (int i = 1; i <= b; i++)
        Console.WriteLine($"{i, 3}  {i * i * i, 4}");
}
if (number < 1)
{
    Console.WriteLine("Введите положительное число");
    return;
}
PrintCube(number);



// Console.WriteLine("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 0)  
// {
//     Console.WriteLine("  x    x**3 ");
//     for(int i=1; i<=number; i++)
//     {
//        Console.WriteLine($"{i, 3}  {i*i*i, 4}"); 
//     }
// }
// else
// {
//     Console.WriteLine("Введите положительное число");
// }