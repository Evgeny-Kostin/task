// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// string num = Console.ReadLine(); 
// СheckForPolydrome(num);
// void СheckForPolydrome(string number)
// {
//     if (num[0]==num[4] && num[1]==num[3])
//     {
//         Console.WriteLine($"{num} - палиндром.");
//     }
//         else 
//         {
//             Console.WriteLine($"{num} - НЕ палиндром.");
//         }
// // else if (num<10000 && num>100000)
// // {
// //     Console.WriteLine("неверное число");
// // }
// }
// Console.WriteLine("Все супер, или Мыж в России");

// второе решение

int Prompt (string message)
{
    Console.Write(message);
    string? value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

int ReverseNumber(int a) // приходит число а метод ReverseNumber будет работать для того чтобы переворачивать какое то число
{
    int revNum = 0; //результирующее число для первого прохода оно и нужно 
    int temp = a; // 12321 временна я переменная
    while (temp>0) // число бльше 0
    {
        revNum = revNum*10 + temp %10; //0+1 //10+2=12 //120+3=123 //1230+2 //12320+1 //12 
        temp /= 10; //1232 //123 // 12 // 1 // 0   
    // начала делим нацло на 10 потом 0*10 + temp деленное с остатокм на 10 от нашего значения, собираем от обратного берем последнюю 
    // цифру и при певом проходе в revNum поступает 1 (temp = 12321/10 = 1 остаток от деления; revNum 0*10+1%10=1) 
    //втрой проход revNum=1 1*10(10)+ temp2%10(2)=12
    // третий 12*10+3%10=123
    // четвертый 123*10+2%10=1232
    // пятый 1232*10+1%10=12321 вот и получили такое же число
    
    }
    return revNum;//вернули полученое после 5 проходов число 12321
}

//далее сравниваем полученное число с заданным

int a = Prompt("Введите пятизначное число: ");
int reversed = ReverseNumber(a);

if (a > 9999 && a < 100000)
{
    if (reversed == a)
    {
        Console.WriteLine("ЧИСЛО ЯВЛЯЕТСЯ ПОЛИНДРОМОМ.");
    }
    else
    {
         Console.WriteLine("ЧИСЛО НЕ ЯВЛЯЕТСЯ ПОЛИНДРОМОМ.");   
    }
}
else
{
    Console.WriteLine("Вы ввели не полизначное число");
}