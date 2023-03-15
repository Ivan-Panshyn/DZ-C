// Напишите программу, которая принимает на 
// 1.вход координаты двух точек и 
// 2.находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A");
Console.Write("Xa: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Za: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("Xb: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb: ");
int zB = Convert.ToInt32(Console.ReadLine());

double Leng = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками A и B равно = {Math.Round(Leng, 2, MidpointRounding.ToZero)}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
  return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));  //- теорема пифагора
}