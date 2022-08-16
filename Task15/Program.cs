// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Веедите число ");
int number = Convert.ToInt32(Console.ReadLine());


int NumCount(int num)
{
    int count = 0;
    if (num == 0) return 1;
    while (num > 0)
    {
        count++;
        num = num / 10;
    }
    return count;
}
int res = NumCount(number);
Console.WriteLine($"Количество цифр в числе {number} = {res}");
