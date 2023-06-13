//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница/

Console.WriteLine("Input number:");
int number1 = int.Parse(Console.ReadLine()!); 

if (number1 == 3)
    {
        Console.WriteLine("->Wednesday");
    }
    else if (number1 == 5 )
    {
        Console.WriteLine("->Friday");
    }
    else
        {
            Console.WriteLine("Unknown day!");
        }
