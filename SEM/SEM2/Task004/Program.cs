// напишите программу которая будет принимать на вход 2 числа и выводить, является ли второе число квадратом второго.


Console.WriteLine(" Введите нпервое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());


bool CheckSquare( int a, int b)
{
    return a * a ==b || b * b = a;
}

if (CheckSquare(num1, num2)) System.Console.WriteLine("да");
else System.Console.WriteLine("нет");





