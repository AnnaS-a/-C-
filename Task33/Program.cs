// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных

Console.Clear();
Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

void ConverMatrixToArray(int[,] matrix, int[] array)         // Здесь если у матрицы строк больше чем столбцов 
{                                                                //в массиве будут нули за недостающий столбец
        int k = 0;                                             
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
}
void CountEvenElemet(int[] array)
{
    int tmp = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (tmp == array[i])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{tmp} встречается {count} раз");
            tmp = array[i];
            count = 1;
        }

    }
    Console.WriteLine($"{tmp} встречается {count} раз");
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}
int[,] array2D = CreateMatrixRndInt(3, 4, -9, 9);
int[] arr = new int[m * n];
PrintMatrix(array2D);
System.Console.WriteLine();
ConverMatrixToArray(array2D, arr);
PrintArray(arr);
Array.Sort(arr);
PrintArray(arr);
CountEvenElemet(arr);




// Другие варианты

// Console.WriteLine("Введите число строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] mtx = CreateMatrixRandomInt(m, n, -9, 9);

// Console.WriteLine("Исходная матрица:");
// PrintMatrix(mtx);

// Console.WriteLine("Способ 1: Новая перевёрнутая:");

// int[,]? transposedMtx = Transpose(mtx);
// if (transposedMtx != null)
// {
// 	PrintMatrix(transposedMtx);
// }
// else
// {
// 	Console.WriteLine("Невозможно заменить столбцы на строки");
// }

// Console.WriteLine("Способ 2: Транспонированная исходная:");
// if (TransposeV2(mtx))
// {
// 	PrintMatrix(mtx);
// }
// else
// {
// 	Console.WriteLine("Невозможно перевернуть исходную.");
// }

// static int[,]? Transpose(int[,] matrix)
// {
// 	int rowsCount = matrix.GetLength(0);
// 	int colsCount = matrix.GetLength(1);

// 	if (rowsCount != colsCount)
// 		return null;

// 	int[,] transposed = new int[colsCount, rowsCount];

// 	for (int i = 0; i < rowsCount; ++i)
// 	{
// 		for (int j = 0; j < colsCount; ++j)
// 		{
// 			transposed[j, i] = matrix[i, j];
// 		}
// 	}

// 	return transposed;
// }

// static bool TransposeV2(int[,] matrix)
// {
// 	int rowsCount = matrix.GetLength(0);
// 	int colsCount = matrix.GetLength(1);

// 	if (rowsCount != colsCount)
// 		return false;


// 	for (int i = 0; i < rowsCount; ++i)
// 	{
// 		for (int j = i + 1; j < colsCount; ++j)
// 		{
// 			SwapElements(matrix, i, j);
// 		}
// 	}

// 	return true;
// }

// static void SwapElements(int[,] matrix, int row, int col)
// {
// 	var tmpItem = matrix[row, col];
// 	matrix[row, col] = matrix[col, row];
// 	matrix[col, row] = tmpItem;
// }

// static int[,] CreateMatrixRandomInt(int rows, int cols, int min, int max)
// {
// 	int[,] matrix = new int[rows, cols];

// 	Random rnd = new Random();
// 	max = max + 1;
// 	for (int row = 0; row < rows; ++row)
// 	{
// 		for (int col = 0; col < cols; ++col)
// 		{
// 			matrix[row, col] = rnd.Next(min, max);
// 		}
// 	}
// 	return matrix;
// }

// static T[,] PrintMatrix<T>(T[,] matrix, string format = "0") where T : struct, IFormattable
// {
// 	int rowsLastIndex = matrix.GetLength(0) - 1;
// 	int colsLastIndex = matrix.GetLength(1) - 1;
// 	for (int row = 0; row <= rowsLastIndex; ++row)
// 	{
// 		Console.Write("[");
// 		for (int col = 0; col < colsLastIndex; ++col)
// 		{
// 			Console.Write($"{matrix[row, col].ToString(format, null),4}, ");
// 		}
// 		Console.WriteLine($"{matrix[row, colsLastIndex].ToString(format, null),4}]");
// 	}
// 	return matrix;
// }



// int[] CheckMatrix(int[,] array, int max)
// {
//     int[] resarray = new int[(max+1)];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             resarray[array[i, j]] += 1;
//         }

//     }
//     return resarray;
// }









