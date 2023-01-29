// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void FillArrayWithRandom(int[,] matrix, int m, int n)
{
   for(int i = 0; i < m; i++)
    {
      for(int j = 0; j < n; j++)
       {
         matrix[i,j] = new Random().Next(1, 30);
         Console.Write(matrix[i,j] + "\t");
       }
        Console.WriteLine();
    }
   
Console.WriteLine();
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix, m, n);

void NewMatrix(int[,] array, int rows, int columns)
{
      for(int j = 0; j < columns; j++)
       {
        double pr = 0;
        for(int i = 0; i < rows; i++)
       {
         pr += array[i,j];
       }
    Console.WriteLine($"Среднее арифметическое значаний столбца {j} = {Math.Round(pr / rows, 2)}");
    }
}
NewMatrix(matrix, m, n);