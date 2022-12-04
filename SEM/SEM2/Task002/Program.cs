// напишите программу которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
System.Console.WriteLine($"random numbet from 100 to 999 is {number}");

int Numprint(int num)
{
int firstDigit = num / 100;
int secondDigit = num % 10;
return firstDigit * 10 + secondDigit;

}
int result = Numprint( number);

System.Console.WriteLine($"{result}");
