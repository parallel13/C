// 17. Напишите программу, которая на вход принимает координаты точки (X; Y) не равне 0 
//и выдает номер четверти плоскости



System.Console.WriteLine("Введите координату точки X");
int x= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату точки Y");
int y= Convert.ToInt32(Console.ReadLine());

int qarter = Qarter(x, y);
string result = qarter >0 ? $"четверть - {qarter}"
                            : "Введены не корректные координаты";

System.Console.WriteLine(result);
int Qarter(int xc, int yc)
{
    if(xc > 0 && yc > 0) return 1;
    if(xc < 0 && yc > 0) return 2;
    if(xc < 0 && yc < 0) return 3;
    if(xc > 0 && yc < 0) return 4;
    return 0;
}

