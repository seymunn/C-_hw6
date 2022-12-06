//Задача 41: 
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите кол-во чисел:");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayInt (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число:");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}

int GetAmountPositiveNum(int[] array)
{
    int PositiveNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) PositiveNum += 1;
    }
    return PositiveNum;
}

int[] arr = CreateArrayInt(5);
int AmountPosNum = GetAmountPositiveNum(arr);
PrintArray(arr);
Console.WriteLine($"-> {AmountPosNum}");