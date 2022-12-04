// напишите программу которая на ввод принимает 3 числа и и выдает максимальное из этих чисел
Console.WriteLine(" Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());



Console.WriteLine(" Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1 >= num2 && num2 >= num3)
{
Console.WriteLine($" max={num1}");

}


else if (num2 >= num1 && num1 >= num3)
{
    Console.WriteLine($" max={num2}");
}

else if (num3 >= num2 && num2 >= num1)
{
    Console.WriteLine($" max={num3}");
}
