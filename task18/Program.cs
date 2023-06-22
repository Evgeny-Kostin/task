//Задача 18. Напишите программу, которая по заданному номеру четверти,
//показывет диапазон возможных координат точек в этой четверти. (x и y).


int number = Prompt ("Введите номер четверти: ");

FindNumberQuarter(number);

void FindNumberQuarter (int number)
{
if(number == 1)
{
    Console.WriteLine("x>0, Y>0");
}
else if (number == 2)
{
    Console.WriteLine("x<0, y>0ь");
     
}
else if (number == 3)
{
    Console.WriteLine("x<0, y<0");
}
else if (number == 4)
{
    Console.WriteLine("x>0, y<0");
}
else //обработка ввода некорректного значения 1;0 или 0;0
{
    Console.WriteLine(" Ошибка");
}
}
int Prompt (string message) 
{         
    Console.Write(message);
    int number=int.Parse(Console.ReadLine()!); 
    return number;
}
