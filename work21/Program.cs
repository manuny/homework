﻿Console.Clear();
Console.Write("Введите координату X1: ");
Double X1 =Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y1: ");
Double Y1 =Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z1: ");
Double Z1 =Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X2: ");
Double X2 =Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y2: ");
Double Y2 =Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z2: ");
Double Z2 =Convert.ToDouble(Console.ReadLine());
Double l = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
Console.WriteLine(Math.Round(l,2));