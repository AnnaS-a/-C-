// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    if (size == 0) return new int[] { };

    int[] array = new int [size];
    Random rnd = new Random();
        
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

bool GetDigit(int[]array, int num)
{
    if (array == null || array.Length <= 0) return false;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] == num) return true;
    }
    return false;
}
int[] arr = CreateArrayRndInt(12, 0, 20);
string res = GetDigit(arr, digit) ? "Да" : "Нет";
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.Write($" -> {res}");
}
PrintArray(arr);
//string res = GetDigit(arr, digit) ? "Да" : "Нет";
//Console.Write($" -> {res}");