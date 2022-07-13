/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int [] GetArray(int dimension)
{
int[] arr = new int[dimension];
Random randomizer = new Random();

for(int i=0; i < arr.Length; i++)
{
   arr[i] = randomizer.Next(0, 10);
}

return arr;
}


void PrintArray(int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
   Console.Write($"{arr[i]} ");
}
}

int Summary (int [] arr)
{
   int sum = 0;
for (int i = 0; i < arr.Length; i = i + 2)
{
   sum = sum + arr[i];
}
return sum;
}

Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());

Console.Clear();


int [] arr = GetArray(dimension);
PrintArray(arr);
Console.WriteLine();

int sum = Summary(arr);
Console.WriteLine($"Сумма чисел стоящих на нечетных позициях в массиве = {sum}");