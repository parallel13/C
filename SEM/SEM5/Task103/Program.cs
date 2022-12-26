// задайте массив вещественных чисел
// найдите разницу между максимальным и минимальным значением.

double[] CreateRandomArray(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double rndDoble = rnd.NextDouble() * (max - min) + min;

        array[i] = Math.Round(rndDoble, 2);
    }
    return array;
}


void PrintArray(double[] array)
{
    System.Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, "); 
        else System.Console.Write($"{array[i]}");    
    }
    System.Console.WriteLine("]");
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(max < array[i]) max = array [i];
    }
    return max;
}
double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i]) min = array [i];
    }
    return min;
}

double[] arr = CreateRandomArray(6 , 0, 10);
PrintArray(arr);

double max= Max(arr);
double min= Min(arr);

double subtraction = max- min;

System.Console.WriteLine($"MAX= {max}, Min= {min}, разница равна {subtraction} ");
//int summ = Summ(arr);
//System.Console.WriteLine($"сумма нечетных элементов массива на промежутке  [100; 999] равно {summ}");