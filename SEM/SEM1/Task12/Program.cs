// напишите программу которая на вход принимает одно число (N).а в ответе показывает все целые четные числа в промежутке 1 до N

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int counter = 2;

while (counter <= number)
{
    Console.Write($"{counter} ");
    counter = counter + 2;
}