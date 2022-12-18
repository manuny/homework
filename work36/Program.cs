void InputArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(1,20);
}
int ReleaseArray(int[] array, int k)
{

	for (int i = 0; i < array.Length; i++)
	{
		if ( i % 2 != 0)
			k = k + array[i];
	}
	return k;
}
Console.Clear();
Console.Write("Введите количество элементов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($" массив [{string.Join(" , ", array)}]");
int k = 0;
ReleaseArray(array, k);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + ReleaseArray(array, k));
