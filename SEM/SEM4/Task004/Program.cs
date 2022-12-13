// Напишите программу которая выводит массив из 8 элементов , заполненный нулями и единицами в случайном порядке


int[] array = new int[8];

void FillArray(int[] arr)
{
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
    }
}

FillArray(array);
PrintArray(array);
