// задайте массив из 12 элементов, заполненный случайными числами в промежутке [-9 , 9].
// найдите сумму отрицательных и положительных элементов массива.


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
System.Console.Write("[ ");
void PrintArray(int[] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, "); 
        else System.Console.Write($"{array[i]}");    
    }

}
System.Console.WriteLine("]");
int[] GetSumm(int[] array)
{
    int sumNegative = default;
    int sumPos = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
        else sumPos += array[i];
    }
    int[] result = {sumNegative, sumPos};
    return result;

}



int[] arr = CreateRandomArray(12, -9, 9);
PrintArray(arr);
int[] result = GetSumm(arr);

System.Console.WriteLine($" Сумма положительных чисел равна {result[1]}");
System.Console.WriteLine($" Сумма отрицательных чисел равна {result[0]}");







