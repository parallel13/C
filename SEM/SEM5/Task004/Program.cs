// задайте равномерный массив из 123 случайных чисел.
// найдите количество элементов массива , значения которых лежат на отрезке []

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


int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 100) count++;
    }
    return count;

}



int[] arr = CreateRandomArray(12, 0, 200);
PrintArray(arr);

int count = Count(arr);
System.Console.WriteLine($"количество элементов в промежудке [10, 100] равно {count}");
