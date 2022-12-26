// напишите программу которая проверяет наличие числа в массиве

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{

    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, "); 
        else System.Console.Write($"{array[i]}");    
        
        
    }
    System.Console.WriteLine("]");
}

bool SeachArrayNum(int[] array, int num)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            result = true;
            break;
        }
    }
    return result;
}


    int[] arr = CreateRandomArray(20, 0, 20);
    PrintArray(arr);
System.Console.WriteLine("введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());
if (SeachArrayNum(arr, number)) Console.WriteLine("Да");
else System.Console.WriteLine("Нет");
