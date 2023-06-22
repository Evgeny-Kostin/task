// Задача№13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78  -> третьей цифры нет
//32679 -> 6


//Console.Clear();
//Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());                 
//int secondValue = number%10;                                //находим второе число
//Console.WriteLine(secondValue + " -> Третье число"); 
//if (number<100) {
//    Console.WriteLine("Третьей цифры нет");
//}
//Console.WriteLine(secondValue + " -> Третье число");

//объяснение преподавателем
//string mess = "введите число: " можно и так тогда в инт промт mess
int number = Prompt ("Введите число: "); //таким образом можно несколько чисел вставлять number1,2,3,4
FindTherdNumber(number);                 //прописанно универсально для всех намберов только вводи новый намбер

int Prompt (string message) //название любое ф-ция типа инт, приходит переменная типа стринг назвали месседж
{
    Console.Clear();
    Console.WriteLine(message);
    int num = Math.Abs(int.Parse(Console.ReadLine())); //int.Parse(Console.ReadLine()); Делает положительным входящее отрицательное значение
      //если придет от пользователя отрицательное значение
    return num; // для того и создали промт , чтобы число вернуть
}
void FindTherdNumber (int num) // название - отражение сути действия, тип войд -возвращать ничего не будет
{
    if(num<100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (num>=1000) // если больше 4 знаков, число уменьшаем до 3 чтобы оно не попало в цикл и перешло в инт ферднамбер%10
        {
            num = num/10;
        }
        int therdNumber = num%10; // нужно для того чтобы в цикл ваил не заходить если вводится трез хнач чило ведь цикл с 4 зн числа работает
        Console.WriteLine($"Третья цифра {therdNumber}");
    }
}
