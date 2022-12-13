// напишите программу которая на вход принимает число А и на выход выдает сумму чисел от 1 до А


System.Console.WriteLine("Введите число N");
int num= Convert.ToInt32(Console.ReadLine());

int Factorial(int numb)
{
    int fact = 1;
    for (int i = 1; i <= numb; i++)
    {
        fact = fact * i;
    }

    return fact;
}

int factorial = Factorial(num);
System.Console.WriteLine($"факториал числа {num} => {factorial}");



// int count = 1;

// while (count <= num)
// {
//     System.Console.WriteLine($"{count} -> {count * count}");
// count++;

// }
