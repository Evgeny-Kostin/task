// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10



// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }


// void Transformation(int res)
// {
//     string result = string.Empty;
//     while (res > 0)
//     {

//         int remainder = res % 2;
//         res /= 2;
//         result = remainder.ToString() + result;
//     }

//     Console.Write($"В двоичном коде число равно: " + result);
// }

// int number = Prompt("Введите число: ");
// Transformation(number);

Console.Write("Введите десятичное число: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = DecimalToBinary(decimalNumber);

        Console.WriteLine($"Двоичное представление числа {decimalNumber} равно: {binaryNumber}");
    

    static string DecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }

        string binary = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binary = remainder.ToString() + binary;
            decimalNumber = decimalNumber / 2;
        }

        return binary;
    }