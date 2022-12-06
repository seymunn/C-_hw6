//Задача 43: 
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1:");
double numB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1:");
double numK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
double numB2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2:");
double numK2 = Convert.ToDouble(Console.ReadLine());

double GetX(double b1, double k1, double b2, double k2)
{
    double X = (b2 - b1) / (k1 - k2);
    return X;
}
double GetY(double b1, double k1, double X)
{
    double Y = k1 * X + b1;
    return Y;
}

if (numK1 == numK2) Console.WriteLine("Точек пересечения нет.");
else
{
    double numX = GetX(numB1, numK1, numB2, numK2);
    double numY = GetY(numB1, numK1, numX);
    Console.WriteLine($"b1 = {numB1}, k1 = {numK1}, b2 = {numB2}, k2 = {numK2} -> ({numX}, {numY})");
}