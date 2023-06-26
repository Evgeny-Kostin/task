// Задача 28: Напишите программу, которая 
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int ProductOfNumbers(int numberN)
{
    int sum = 1;
    for (int i =1; i<=numberN; i++)
    {
        sum = sum*i; 
        //Console.Write(i + " "); // если добавить в цикл выведет и все числа и сумму чисел
    }
    return sum;
}
int numberN = Prompt ("введите число: "); 
int result = ProductOfNumbers(numberN);
Console.WriteLine("Произведение чисел от 1 до N " + result);

// int N = TakeUserNum();
// Console.WriteLine($"{N} -> {ProductNum(N)}");

// int ProductNum(int N)
// {
//     int product = 1;

//     for(int i = 1; i <= N; i++)
//         product *= i;            // product = product * i

//     return product;
// }

// int TakeUserNum()
// {
//     int userNum;

//     while(!int.TryParse(Console.ReadLine(), out userNum)) // также не смогли спарсить заъодим в цикл
//         Console.WriteLine("Пожалуйста введите число!");

//     return userNum;
// }