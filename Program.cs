/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
int CountN(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
            if (array[i] > 0)
                count++;
    return count;
}
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(CountN(array));
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2 
значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
void point(ref double b1, ref double k1, ref double b2, ref double k2)
{
    double x = (b2-b1) / (k1 - k2); 
    double y = k1 * x + b1;
    Console.WriteLine(x);
    Console.WriteLine(y);
}
Console.Write("Введите 4 координаты: ");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
point(ref b1, ref k1, ref b2, ref k2);
*/