﻿	int rec(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return rec(m - 1, 1);
			}
			return rec(m - 1, rec(m, n - 1));
		}
	
Console.Clear();
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));