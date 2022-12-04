// напишите программу которая выводит случайное число из заданного отрезка
// показывает наибольшую цифру числа

Console.WriteLine(" Введите начало отрезка");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите тконец отрезка");
int num2 = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next(num1, num2);   //случайное число в отрезке
System.Console.WriteLine($"случайное число из диапазона {num1}, {num2} => {number} ");



//if (firstDigit > secondDigit) System.Console.WriteLine($"наибольшая цифра числа {number} = {firstDigit}");
//else System.Console.WriteLine($"наибольшая цифра числа {number} = {secondDigit}");



int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    //if(firstDigit > secondDigit) return firstDigit;
    //return secondDigit;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}


int maxDigit = MaxDigit(number);

Console.WriteLine($"наибольшая цифра числа {number} = {maxDigit}");





