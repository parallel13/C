// задайте одномерный массив, заполненный случайными числами
// найдите сумму элементов, стоящих на нечетных позициях.

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

int Summ(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        summ = summ + array[i];
    }
    return summ;

}

int[] arr = CreateRandomArray(6 , 0, 10);
PrintArray(arr);

int summ = Summ(arr);
System.Console.WriteLine($"сумма нечетных элементов массива на промежутке  [100; 999] равно {summ}");