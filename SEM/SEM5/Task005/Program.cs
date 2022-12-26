// найдите произведение пар чисел в одном массиве, парой считается перое и последнее число, второе и преждпоследнее...
// результат запишите в новом массиве

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


int[] ResultMassive(int[] array)
{
    int size = array.Length /2;
    if(array.Length % 2 == 1) size = size + 1;
    int[] resultMassive = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultMassive[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length % 2 == 1) resultMassive[size-1] = array[size - 1];
    return resultMassive;

}






int[] arr = CreateRandomArray(5, 0, 15);
PrintArray(arr);



int[] resultMassive = ResultMassive(arr);
PrintArray(resultMassive);


