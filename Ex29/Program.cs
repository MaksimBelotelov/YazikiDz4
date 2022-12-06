// Программа задает массив из 8 элементов и выводит их на экран

Console.Write("Введите размерность массива (например 8):");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArray(size);

PrintArray(arr);

int[] FillArray(int size)
{
    int[] resultArray=new int[size];
    for(int i=0; i<size; i++)
    {
        Console.Write($"Введите элемент {i}: ");
        resultArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    return resultArray;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Введенный массив: ");
    for(int i=0; i<arr.Length; i++)
        Console.Write($"{arr[i]} ");
}