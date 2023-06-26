// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76
// Был урок полезен вам? Что было сложно?

using System;
class HelloWorld {
  static void Main()
  {
      
        double [] arr=GetArrayDouble(20,-1000,1000);
        PrintArrayDouble(arr);
        double result=distace(arr);
        Console.Write($"\n{result}");
    }
  static double distace(double[] arr)
  {
      
        double maxValue=arr[0];
        double minValue=arr[0];
      foreach(int num in arr)//ноль не четноё так как в реальности счёт с 1
      {
          if(maxValue<num)
          {
              maxValue=num;
          }
          if(minValue>num){
            minValue=num; 
          }
      }
      return maxValue-minValue;
  }
  
  static void PrintArrayDouble(double[] arr)
    {
        // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]} ");
    // }
    foreach (double el in arr)
    {
        Console.Write($"{el} ");
    }
    }
    static int Prompt(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
            return number;
    }   
    static int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);

    }
    return result;
}
 static double[] GetArrayDouble(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < result.Length; i++)
    {
        double coeff= new Random().NextDouble();
        result[i] =minValue+(maxValue-minValue)*coeff;

    }
    return result;
}
}


// / Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// // Парой считаем первый и последний элемент, второй и предпоследний
// // и т.д. Результат запишите в новом массиве. 
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

// int size = Prompt("Введите размерность массива: ");
// int minValue = Prompt("Введите минимальное число диапазона массива: ");
// int maxValue = Prompt("Введите максимальное число диапазона массива: ");
// int[] array = GetArray(size, minValue, maxValue);
// PrintArray(array);
// Console.Write(" -> ");
// PrintArray(SearchArray(array));

// int Prompt(string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine()!);
//     return number;
// }
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for(int i =0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1); 
//     }
//     return result;
// }
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for(int i =0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.Write($"{arr[arr.Length-1]}"); //обращаемся к последнему элементу
//     Console.Write("]");
// }

// int[] SearchArray(int[] arr)
// {
//     int index = 0;
//     int[] resArray = new int[(arr.Length + 1) / 2];
//     for(int i =0; i < arr.Length / 2; i++)
//     {  
//         resArray[i] = arr[i] * arr[(arr.Length - 1) - i];
//     }
//     if(arr.Length % 2 == 1)
//     {
//         resArray[(arr.Length - 1) / 2] = arr[(arr.Length - 1) / 2];
//     }
//     return resArray;
// }

// double coeff= new Random().NextDouble();
//         result[i] =minValue+(maxValue-minValue)*coeff;

// https://learn.microsoft.com/ru-ru/dotnet/api/system.random?view=netframework-4.8