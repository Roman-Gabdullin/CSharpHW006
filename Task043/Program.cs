// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double b1 = Meaning("b1");
double k1 = Meaning("k1");
double b2 = Meaning("b2");
double k2 = Meaning("k2");
InterSectionPoint(b1, k1, b2, k2);



void InterSectionPoint(double b1, double k1, double b2, double k2)
{
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}

double Meaning(string nameVariable)
{
    Console.Write($"Введите значение {nameVariable}: ");
    return Convert.ToInt32(Console.ReadLine());
}