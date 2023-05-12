// Задача №21. 
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}
double xa = ReadNumber("Введите координату точки А по Х");
double ya = ReadNumber("Введите координату точки А по Y");
double xb = ReadNumber("Введите координату точки B по Х");
double yb = ReadNumber("Введите координату точки B по Y");

double res = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
Console.WriteLine($"{res:f2}");