// напишите программу которая на вход принимает пятизначное число и проверяет является ли оно палиндромом
System.Console.WriteLine("Введите пятизнаачное число");
int number= Convert.ToInt32(Console.ReadLine());

if(CheckNum(number))
    {
        if (CheckMethod(number))
            {
                System.Console.WriteLine($"число {number} является полиандром");
            }
        else 
            {
                System.Console.WriteLine($"число {number} не является полиандром");
            }

    }
else
    {
        System.Console.WriteLine($"число {number} введено не корректно");
    }
bool CheckMethod(int num)
    {
        int firstDigit = num / 10000;            // 54567/ 10000 = 5.4567 
        int secondDigit = num / 1000 % 10;     // 54567/ 1000 = 54.567 
        int thirdDigit = num / 100 % 10;       // 54567/ 100 = 545.67 
        int fourthDigit = num / 10 % 10;       // 54567/ 100 = 54567 
        int fifthDigit = num % 10;


        return firstDigit == fifthDigit && secondDigit == fourthDigit;
    }

bool CheckNum(int numb)
{  
    return numb >=10000 && numb <=99999;
}
