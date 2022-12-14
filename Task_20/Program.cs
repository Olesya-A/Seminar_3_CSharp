// 20: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) → 5,09 
// A (7,-5); B (1,-1) → 7,21

Console.WriteLine("Введите координаты X Y точки a:");
string XYa = Console.ReadLine()!;
string[] parts1 = XYa.Split(' ');
int Xa = int.Parse(parts1[0]);
int Ya = int.Parse(parts1[1]);

Console.WriteLine("Введите координаты X Y точки b:");
string XYb = Console.ReadLine()!;
string[] parts2 = XYb.Split(' ');
int Xb = int.Parse(parts2[0]);
int Yb = int.Parse(parts2[1]);

double distanseAB = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2));
Console.WriteLine(distanseAB - distanseAB % 0.01); 