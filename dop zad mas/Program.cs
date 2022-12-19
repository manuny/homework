void InputArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(1, 31);
}

void oddArray(int[] array, int[] odd)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 != 0)

			odd[i] = array[i];

	}

}

void evenArray(int[] array, int[] even)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)

			even[i] = array[i];

	}

}

Console.Clear();
Console.Write("Введите количество элементов в массиве от 1 до 100: ");

int n = Convert.ToInt32(Console.ReadLine());
while (n > 100)
{
	Console.Write("Вы ошиблись!\nВведите количество элементов в массиве от 1 до 100: ");
	n = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[n];
InputArray(array);
Console.WriteLine($" Массив {string.Join("  ", array)}");
int[] odd = new int[n];
oddArray(array, odd);
Console.WriteLine($"Нечетные дни месяца {string.Join(" ", odd.Where(x => x != 0))}");
int[] even = new int[n];
evenArray(array, even);
Console.WriteLine($"Четные дни месяца {string.Join(" ", even.Where(x => x != 0))}");