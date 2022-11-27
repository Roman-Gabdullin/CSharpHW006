// Дополнительно. Дан массив. Найдите MEX массива. 
// MEX (Minimum EXcluded) - минимальный отсутствующий элемент.

Console.Write("Введите количество элементов массива: ");
int elements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int minnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int maxnum = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elements];
GetArray(array,minnum,maxnum);
PrintArray(array);
int mex = MEX(array);
Console.WriteLine();
Console.Write(mex);



void GetArray(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(min,max+1);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int MEX (int[] array)
{
    for (int mex = 0; mex < array.Length; mex++)
    {
        bool notFound = true;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == mex)
            {
                notFound = false;
                break;
            }
        }
        if (notFound)
        {
            return mex;
        }
    }
    return array.Length;
}