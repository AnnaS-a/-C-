// Задача 24
// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
// 7 -> 28          4 -> 10




Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= num; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");
