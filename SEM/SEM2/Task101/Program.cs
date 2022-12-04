// напишите программу которая принимает на вход трехзначное число, и выводит вторую цифру этого числа 


Console.WriteLine(" Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if(Check(number))
{
int result = Method(number);
System.Console.WriteLine($"вторая цифра введенного числа равна {result}");
}
else
{
    
}
int Method(int num)
{

int secondDigit = num % 100 / 10;
return secondDigit;
}

bool Check(int numb)
{
    return numb >=100 && numb <=999;
}



