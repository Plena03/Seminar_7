// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Программа считает среднее арифметическое элементов в каждом столбце.");
Console.WriteLine();

Console.WriteLine("Введите число строк (m)");
if(!int.TryParse(Console.ReadLine()!, out var m)) {
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");
if(!int.TryParse(Console.ReadLine()!, out var n)) {
    Console.WriteLine("Всё плохо");
}

double[,] array = new double[m, n];
CreateArrayWithRandomNumbers(array);
PrintArray(array);
Console.WriteLine();

void CreateArrayWithRandomNumbers(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void PrintArray(double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double number = Math.Round(array[i, j], 1);
        Console.Write(number + " ");
      }
      Console.WriteLine();
  }
}

int[,] arrayNew = new int[m, n];
arrayNew = ArrayNew(array);

ArrayInt(arrayNew);
Console.WriteLine();

Console.WriteLine("Cреднее арифметическое число равно:");
for (int i = 0; i < n; i++)
{
  double sum = 0;
  for (int j = 0; j < m; j++)
  {
    sum += arrayNew[j, i];
  }
  sum = Math.Round(sum / m, 1);
  Console.WriteLine($"элементов в столбце {i} = {sum}");
}

int[,] ArrayNew(double[,] array)
{
  int[,] arrayNew = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayNew[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayNew;
}

void ArrayInt (int[,] arrayNew){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayNew[i, j] + " ");
      }
      Console.WriteLine();
  }
}
