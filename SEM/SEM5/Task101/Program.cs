// созадайте массив заполненный случайными положительными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.

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
        if(array[i] % 2 == 0) count++;
    }
    return count;

}

int[] arr = CreateRandomArray(6 , 100, 999);
PrintArray(arr);

int count = Count(arr);
System.Console.WriteLine($"количество четных чисел на промежутке [100, 999] равно {count}");