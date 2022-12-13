// напишите программу которая на вход принимает число А и на выход выдает сумму чисел от 1 до А

System.Console.WriteLine("Введите число N");
int numb= Convert.ToInt32(Console.ReadLine());


int sumNumbers = SumNumbers(numb);
System.Console.WriteLine(sumNumbers);
int SumNumbers(int num)
{
    int sum = default;
    for (int i = 1; i <=num; i++)
    {
        sum = sum + i;
    }
    return sum;
}



