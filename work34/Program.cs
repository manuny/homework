void InputArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(100, 999);
}
int ReleaseArray(int[] array, int k)
{

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)
			k = ++k;
	}
	return k;
}
Console.Clear();
int[] array = new int[100];
InputArray(array);
Console.WriteLine($" массив [{string.Join(" , ", array)}]");
int k = 0;
ReleaseArray(array, k);
Console.WriteLine("Количество четных чисел: " + ReleaseArray(array, k));