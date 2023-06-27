// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int size = Prompt("Введите размерность массива: "); //вызываем сюда промпт
int minValue = Prompt("Введите минимальное число диапазона чисел в массиве: ");
int maxValue = Prompt("Введите максимальное число диапазона чисел в массиве: ");
int[] array = GetArray(size, minValue, maxValue); // вызов метода работы с массивом
PrintArray(array); // затем вызвать метод печати массива
int[] resSum = GetSumm(array);
Console.WriteLine($"Сумма положительных чисел = {resSum[0]}, сумма отрицательных чисел = {resSum[1]}");


int Prompt(string message) // метод работы с пользователем
{
    Console.Write(message); // печатаем
    int number = int.Parse(Console.ReadLine()); // должен вернуть число , конвертируем
    return number; // тк возвращаемого типа делаем ретерн
}

int[] GetArray(int size, int minValue, int maxValue) // переменные не тоже самое что описанные с Prompt это переменные отвеч за работы внутри метода
{
    int[] result = new int[size]; // сюда складывам все значения из метода
    for (int i = 0; i < result.Length; i++) // по индексам за тидекс отвеч i
    {                //result.Length размерность массива
        result[i] = new Random().Next(minValue, maxValue + 1); // +1 здесь потому что указаны конкретные рамки и если ввести 9 то учтется до 8 правый предел поэтому +1
       //просто посмотреть Console.Write($"{result[i]} ");
       //имя индекс те с 0-го индекса начинаем заполнение массива
    } 
    return result;
}

void PrintArray(int[] arr)
{
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]} ");
    // }
    foreach (int el in arr)
    {
        Console.Write($"{el} ");
    }
}

int[] GetSumm(int[] array) // по сути это массив из 2 элементов и создан для того чтобы эти 2 элемента суи+ и сум- хранить
{

    int[] result = new int[2];

    foreach (int el in array)
    {
        if (el > 0) result[0] += el; // на 0 позиции положит знач
        if (el < 0) result[1] += el; // на 1 отрицательные
    }
    return result;
}















// кортежи

// 15:35
// (int, int) GetSum(){result = (sum, sum) resutrn result} в общем виде