// написать программу которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа

Console.WriteLine("введите целое число");
int number = Convert.ToInt32(Console.ReadLine());


if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10;
    System.Console.WriteLine($"Последняя цифра числа => {lastDigit}");
}

else Console.WriteLine("Введенное число не трехзначное");


