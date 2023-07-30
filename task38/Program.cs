/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
void InputArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        array[i]=new Random().Next (0,100);
}
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"разница = {array.Max()} - {array.Min()}");
