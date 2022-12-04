// программа которая на вход принимает число и выводит квадраты чисел от 1 до N 


System.Console.WriteLine("Введите число N");
int num= Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= num)
{
    System.Console.WriteLine($"{count} -> {count * count}");
count++;

}


