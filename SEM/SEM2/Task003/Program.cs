// напишите программу которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому.
// если число 2 не кратно числу 1 то программа выводит остаток от деления

Console.WriteLine(" Введите нпервое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());


bool Remasing( int a, int b)
{
    return b % a ==0;
}

if (Remasing(num1, num2)) System.Console.WriteLine("да");
else System.Console.WriteLine("нет");

