// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("введите количество строк");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("введите количество столбцов");
// int columns = int.Parse(Console.ReadLine()!);
// double[,] numbers = new double[rows, columns];
// GetArray(numbers);
// PrintArray(numbers);

// double [,] GetArray(double[,] array)
// {
//     // double[,] numbers = new double[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
//     return numbers;
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
        
//         Console.WriteLine("");
//     }
// }




// double rows = Prompt("Введите колличество строк: ");
// double columns = Prompt("Введите колличество столбцов: ");
// double minValue = Prompt("Введите число для минимального диапазона значений: ");
// double maxValue = Prompt("Введите число для максимального диапазона значений: ");

// double[,] array = GetArray(rows, columns, minValue, maxValue);
// PrintArray(array);

// double Prompt(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// double[,] GetArray(double rows, double columns, double minValue, double maxValue)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10; // [0,0] , [0,1] , [0,2]....//[1,0], [1,1] , [1,2]

//         }
//     }
//     return result;
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // GetLength(0) - длина строки
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // GetLength(1) - длина столбцов
//         {
//             Console.Write(array[i, j] + " ");

//         }
//         Console.WriteLine();
//     }
// }


