/*

*/
Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Сгенерированно {dimension} чисел в массиве:");
Console.WriteLine();

double[] arr = new double[dimension];
  for (int i = 0; i < arr.Length; i++ )
  {
    arr[i] = new Random().NextDouble()*10;
    Console.WriteLine($"{arr[i]:F2}  ");
  }


double max = arr[0];
double min = arr[0];

  for (int i = 1; i < arr.Length; i++)
  {
    if (max < arr[i])
    {
      max = arr[i];
    }
        if (min > arr[i])
    {
      min = arr[i];
    }
  }

double decision = max - min;

Console.WriteLine();
Console.WriteLine($"Разница между между максимальным  и минимальным элементами: {max:F2} - {min:F2} = {decision:F2}");
Console.WriteLine();
Console.WriteLine();