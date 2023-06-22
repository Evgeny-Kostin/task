//Задача 21. Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
// координаты x y z A(3,6,8)

//int x1 = Coordinate("x", "A");
//int y1 = Coordinate("y", "A");
//int z1 = Coordinate("z", "A");
//int x2 = Coordinate("x", "B");
//int y2 = Coordinate("y", "B");
//int z2 = Coordinate("z", "B");

//int Coordinate (string coordName, string pointName);
//{
    //int num = int.Parse(Console.ReadLine()!); 
    //Console.WriteLine($"Координата {coordName} точки {pointName}");     
    //return num; 
//}



int numberA1 = Prompt ("Введите координату А1: ");
int numberA2 = Prompt ("Введите координату А2: ");
int numberA3 = Prompt ("Введите координату А3: ");
int numberB1 = Prompt ("Введите координату B1: ");
int numberB2 = Prompt ("Введите координату B2: ");
int numberB3 = Prompt ("Введите координату B3: ");

//DistanceBetweenPoints(numberA1);
//DistanceBetweenPoints(numberA2); 
//DistanceBetweenPoints(numberA3);                 

int Prompt (string message) 
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!); 
    
    return num; 
}


Console.WriteLine($"A ({numberA1}, {numberA2}, {numberA3}); B ({numberB1}, {numberB2}, {numberB3}) ");