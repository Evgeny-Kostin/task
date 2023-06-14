//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница/

Console.Write("Введите номер: ");
int number1 = int.Parse(Console.ReadLine()!); 

if (number1 == 3)
    {
        Console.Write("Среда");
    }
    else if (number1 == 5 )
    {
        Console.Write("Пятница");
    }
    else if (number1 == 1)
        {
            Console.Write("Понедельник");
        
        }
        else if (number1 == 2 )
    {
        Console.Write("Вторник");
    }
    else if (number1 == 4)
        {
            Console.Write("Четверг");
        
        }
        else if (number1 == 6)
        {
            Console.Write("Суббота");
        
        }
        else if (number1 == 7)
        {
            Console.Write("Воскресенье");
        
        }
        else if (number1 >= 8)
        {
            Console.Write("Ведите число от 1 до 7");
        }
