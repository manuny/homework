﻿Console.Clear();
Console.Write("Введите значение k1:");
Double k1 =Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1:");
Double b1 =Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2:");
Double k2 =Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2:");
Double b2 =Convert.ToDouble(Console.ReadLine());
Double x = (b2 - b1) / (k1 - k2);
Double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых: " + (x,  y));