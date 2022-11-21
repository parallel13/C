// напишите программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Введите первое число");
int sqare = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number = Convert.ToInt32(Console.ReadLine());
if (sqare == number * number)
{
Console.WriteLine($"{sqare} квадрат {number}");

}


else Console.WriteLine($"{sqare} не является квадратом {number}");
