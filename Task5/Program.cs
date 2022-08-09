// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);  //интервал от 10 до 99 (99+1)
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
 
int firstDigit = number / 10;  // 7  напр. 78/10=7 (целая часть от деления )
int secondDigit = number % 10;  // 8 напр. 78/10 оттаток 8

if (firstDigit == secondDigit) Console.WriteLine("Цифры одинаковые");
else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа из отрезка {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа из отрезка {secondDigit}");


// Другой вариант решения, через метод (функцию)

// int number = new Random().Next(10, 100);  //интервал от 10 до 99 (99+1)
// Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

// int MaxDigit(int num)
// {
//     int firstDigit = num / 10;
//     int secondDigit = number % 10;
//     return firstDigit > secondDigit ? firstDigit : secondDigit;
// }
// int result = MaxDigit(number);
// Console.WriteLine($"Наибольшая цифра числа из отрезка 10 - 99 -> {number} -> {result}");


// Другой вариант решения, через метод (тернальный оператор)

// int number = new Random().Next(10, 100);  //интервал от 10 до 99 (99+1)
// Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
// int firstDigit = number / 10;  
// int secondDigit = number % 10;  

// int res = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа из отрезка 10 - 99 -> {number} -> {res}");
