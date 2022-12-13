// напишите программу которая на вход принимает число А и на выход выдает количество цифр этого числа

System.Console.WriteLine("Введите число N");
int num= Convert.ToInt32(Console.ReadLine());

int NumbersCount(int numb)
{
    int count = 0;
    while (numb > 0)
    {
        numb /=10;
        count++;
    }

    return count;
}

int numbersCount = NumbersCount(num);
System.Console.WriteLine($"количество цифр числа {num} => {numbersCount}");



