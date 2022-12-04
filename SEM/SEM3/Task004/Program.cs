// напишите программу, которая принимает на вход координаты 2х точек и находит расстояние между ними в пространстве

System.Console.WriteLine("Введите координату точки X");
int xa= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату точки Y");
int ya= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату точки X");
int xb= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату точки Y");
int yb= Convert.ToInt32(Console.ReadLine());

double distance = Distance(xa, ya, xb, yb);

System.Console.WriteLine($"расстояние между точками равно {distance}");


double Distance( int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}


