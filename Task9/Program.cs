// Напишите программу, которая будет принимать на вход два числа и выводить, является ли одно число
// квадратом другого.
// -4, 16 -> да
// 6, 4 -> нет



Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool IsSquare (int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
if (IsSquare (number1, number2)) Console.WriteLine("Да, одно число является квадратом другого");
else Console.WriteLine("Нет, одно число не является квадратом другого");
