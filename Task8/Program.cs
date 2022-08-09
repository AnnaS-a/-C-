// Напишите программу, которая будет принимать на вход число и выводить, является ли это число 7 и 23
// 69 -> не кратно, 
// 161 -> кратно

// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//      Console.WriteLine($"Число {number} кратно числам 7 и 23");
// }
// else Console.WriteLine($"Число {number} не кратно 7 и 23");

// Другой вариант

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

bool Multip (int num, int a, int b)
{
    return num % a == 0 && num % b == 0;
}
if (Multip (number, 7, 23)) Console.WriteLine($"{number} -> Кратно 7 и 23");
else Console.WriteLine($"{number} -> Не кратно 7 и 23");
