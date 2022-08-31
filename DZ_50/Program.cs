// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Программа показывает значение элемента по заданным позициям элемента");
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
PrintArray(array);
CreateArrayWithRandomNumbers(array);
Console.WriteLine();

void PrintArray(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void CreateArrayWithRandomNumbers(double[,] array){
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

Console.WriteLine("Введите позицию элемента через пробел:");

string? positionElement = Console.ReadLine();
int[] position = ElementString(positionElement);

if(position[0] <= m && position[1] <= n && position[0] >= 0 && position[1] >= 0) 
{
  double result = array[position[0]-1, position[1]-1];
  Console.WriteLine($"Значение элемента: {result}");
}
else Console.WriteLine("Такого элемента нет.");

int[] ElementString(string input)
{
  int count = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ' ')
          count++;
  }

  int[] numbers = new int[count];

  int index = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string element = String.Empty;

    while (input[i] != ' ')
    {
      element += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[index] = Convert.ToInt32(element);
    index++;
  }
  return numbers;
}
