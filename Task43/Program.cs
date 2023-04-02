// 1. Напишите программу, которая найдёт точку пересечения двух прямых,2
// 2. заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//    значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите значение b1");
double numbeB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
double numberK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double numberB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double numberK2 = Convert.ToInt32(Console.ReadLine());

double x = (-numberB2 + numbeB1)/(-numberK1 + numberK2);
double y = numberK2 * x + numberB2;

Console.WriteLine($"Точка пересечения двух прямых X: {x}, Y: {y}");