// напишите программу, которая принимает на вход координаты 2х точек и находит расстояние между ними в пространстве 3D

System.Console.WriteLine("Введите координату x точки X");
int xa= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату y точки X");
int ya= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату z точки X");
int za= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату x точки Y");
int xb= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату y точки Y");
int yb= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату z точки Y");
int zb= Convert.ToInt32(Console.ReadLine());

double distance3d = Distance3D(xa, ya, xb, yb, za, zb);

System.Console.WriteLine($"расстояние между точками равно {distance3d}");


double Distance3D( int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1 , 2) + Math.Pow(y2 - y1 , 2) + Math.Pow(z2 - z1 , 2));
}

