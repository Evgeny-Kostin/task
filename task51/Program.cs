// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

int Sum(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + array[i, j];
            }

        }
    }
    return result;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rows = Promt("Введите кол-во строк: ");
int columns = Promt("Введите кол-во столбцов: ");
int minValue = Promt("Мин элемент: ");
int maxValue = Promt("Макс элемент: ");
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
int sum = Sum(array);
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");



// int rows = 6;
//         int columns = 6;
//         Random random = new Random();
//         int[,] array = new int[rows, columns];
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 array[i, j] = random.Next(10); 
//             }
//         }

        
//         Console.WriteLine("Двумерный массив:");
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }


//         int sum = 0;
//         for (int i = 0; i < rows; i++)
//         {
//             sum += array[i, i];
//         }

        
//         Console.WriteLine("Сумма элементов на главной диагонали: " + sum);


//         Console.ReadLine()