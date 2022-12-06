/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (0,0); B (1,1), -> ~1.4
A (2,4); B (0,7) -> ~3.6
*/

Console.WriteLine("Введите координаты двух точек");

int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());


double ab = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));

Console.WriteLine(ab);

