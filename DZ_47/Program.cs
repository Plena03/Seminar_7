//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Программа задает двумерный массив размером m х n, заполненный случайными вещественными числами");
Console.WriteLine();

void PrintArray(double[,] array) {
    for (var i = 0; i < array.GetLength(0); i++) {
        for (var j = 0; j < array.GetLength(1); j++) {
            double number = Math.Round(array[i, j], 1);
        Console.Write(number + "    ");

        }
        Console.WriteLine();
    }
}

double[,] CreateArrayWithRandomNumbers(int m, int n) {
    double[,] result = new double[m,n];
    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++) {
        for (var j = 0; j < result.GetLength(1); j++) {
            result[i,j] = new Random().NextDouble() * 20 - 10;
        }
    }

    return result;
}

Console.WriteLine("Введите число строк (m)");
if(!int.TryParse(Console.ReadLine()!, out var m)) {
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");
if(!int.TryParse(Console.ReadLine()!, out var n)) {
    Console.WriteLine("Всё плохо");
}

PrintArray(CreateArrayWithRandomNumbers(m, n));
 Console.WriteLine();
