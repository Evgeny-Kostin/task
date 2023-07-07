// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();


int[,,] array3D = new int[6, 5, 2];

CreateArray(array3D);
PrintArray(array3D);


void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {

            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({j},{k},{i})\t");
            }
            Console.WriteLine();
        }

    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.Length];
    int number;
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }

            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}


// СПИРАЛЬ
Console.Clear();
int size = 5;
int[,] array = new int[size, size];
SpiralFillArray(array, size);       // Метод № 1 - заполнение массива по спирали. 
PrintArray(array, size);            // Метод № 2 - вывод массива на печать. 

// МЕТОДЫ
// Метод № 1 - заполнение массива по спирали. 
void SpiralFillArray(int[,] array, int size)
{
    int value = 1;                // Значение элемента [0, 0].          
    int i = 0;
    int j = 0;
    while (value <= size * size)  // Диапазон значений элементов массива. 
    {
        array[i, j] = value;
        if (i <= j + 1 && i + j < size - 1)  // Заполнение строк слева направо.
            j++;                             // Возврат увлеличенного значения j.
        else if (i < j && i + j >= size - 1) // Заполнение столбцов сверху вниз. 
            i++;                             // Возврат увлеличенного значения i.
        else if (i >= j && i + j > size - 1) // Заполнение строк справа налево. 
            j--;                             // Возврат уменьшенного значения j.
        else                                 // Заполнение столбцов снизу вверх. 
            i--;                             // Возврат уменьшенного значения i. 
        value++;
    }
}

//  Метод № 2 - вывод массива на печать.
void PrintArray(int[,] array, int size)
{
    Console.WriteLine($"Массив, имеющий размер {size} х {size}, заполнен по спирали.");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}




// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Задача 63: Задайте значение N.
//  Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Range(n)}");

string Range (int n)
{
    if(n == 1)
    {
        return "1";
    }
    return n + ", " + Range(n-1);
}

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
Console.WriteLine("Введите большее значение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите меньшее значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Range(n, m)}");

string Range (int n, int m)
{
    if(n == m)
    {
        return m.ToString();
    }
    return  Range(n-1, m) + ", " + n;
}

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = Prompt("Введите число: ");
Console.WriteLine($"{SumDigit(number)}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int SumDigit(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return SumDigit(n / 10) + (n % 10);
}

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int a = Prompt("Введите основание: ");
int b = Prompt("Введите степень: ");
Console.WriteLine($"{Pow(a, b)}");


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
// быыстрое возведение в степень
// int Pow(int A, int B) 
// {
//     if(B == 0)
//     {
//         return 1;
//     }
//     int temp = Pow(A, B/2);
//     int temp2 = (B % 2 == 1)? A: 1;
//     return temp * temp * temp2;
// }

int Pow(int A, int B)// медленное возведение в степень
{
    if (B == 0)
    {
        return 1;
    }
    return Pow(A, B - 1) * A;
}




