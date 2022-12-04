// напишите программу которая на ввод принимает 2 числа и выводит максимальное из них
Console.WriteLine(" Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());



Console.WriteLine(" Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
Console.WriteLine($" max={num1}");

}

else Console.WriteLine($" max={num2}");

