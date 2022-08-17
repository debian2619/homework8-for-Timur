// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] mass = new int[8, 6];
double[] sred_znach = new double[8];
Random rand = new Random();
  for (int i = 0; i < 8; i++)
  {
      for (int j = 0; j < 6; j++)
      {
          mass[i, j] = rand.Next(0,100);
          Console.Write(mass[i,j] + "\t");
      }
      Console.WriteLine();
  }
Console.WriteLine();
  for (int i = 0; i < 8; i++)
      for (int j = 0; j < 6; j++)
        sred_znach[i] += mass[i, j];
            for (int i = 0; i < 8; i++)
                Console.Write("{0:0.00}  ", sred_znach[i] / 6.0);
            Console.WriteLine();