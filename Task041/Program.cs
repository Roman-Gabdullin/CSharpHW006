// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int quantity;
Console.Write("Введите желаемое количество чисел: ");
quantity = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[quantity];
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
int quant = QuantityGreaterZero(Array);
Console.Write($"Количество чисел больших ноля в массиве = {quant}"); 




void FillArray(int[] array)
{
    Console.WriteLine("введите числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int QuantityGreaterZero(int[] array)
{
    int quanti = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        quanti++;
    }
    return quanti;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}