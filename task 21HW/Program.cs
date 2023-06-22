//Задача 21. Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
// координаты x y z   A(3,6,8)

int numA1 = Prompt ("Введите координату Ax1: ");
int numA2 = Prompt ("Введите координату Ay1: ");
int numA3 = Prompt ("Введите координату Az1: ");
int numB1 = Prompt ("Введите координату Bx2: ");
int numB2 = Prompt ("Введите координату By2: ");
int numB3 = Prompt ("Введите координату Bz2: ");

int Prompt (string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!); 
    
    return num; 
}
double DistanceBetweenPoints = Math.Sqrt(Math.Pow((numB1-numA1), 2) + Math.Pow((numB2-numA2), 2) + Math.Pow((numB3-numA3), 2));

Console.WriteLine($"A ({numA1}, {numA2}, {numA3}); B ({numB1}, {numB2}, {numB3} -> {DistanceBetweenPoints})");
// Math.Sqrt() – математическая функция которая извлекает квадратный корень. В аргументных скобках указывается значение числа, из которого нужно извлечь квадратный корень.

// Math.Pow() – возведения числа в степень. В аргументных скобках через запятую указываются два аргумента (1-ый аргумент - число, которое возводим в степень, 2-ой – степень, в которую возводим число).

// Пример: использование метода Math.sqrt()
// Math.sqrt(9); // 3
// Math.sqrt(2); // 1.414213562373095

// Math.sqrt(1);  // 1
// Math.sqrt(0);  // 0
// Math.sqrt(-1); // NaN
// Math.sqrt(-0); // -0