Console.Clear();
Console.Write("Введите числа через пробел:");
int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int a = 0;
for (int i = 0; i < s.Length; i++)
{
	if (s[i] > 0)
		a = a + 1;
}

Console.WriteLine(a + $" -  чисел > 0 ");