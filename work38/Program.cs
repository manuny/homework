void InputArray(double[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(-100, 100);
}

double MaxArray(double[] array, double max)
{

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > max)
			max = array[i];
	}
	return max;
}

double MinArray(double[] array, double min)
{

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < min)
			min = array[i];
	}
	return min;
}

double Result(double result, double MinArray, double MaxArray)
{
	{
		if (MinArray < 0)
			MinArray = MinArray * (-1);
	
		if (MaxArray < MinArray)
			result = MinArray - MaxArray;
			return result;
	}

		result = MaxArray - MinArray;
	return result;
}


Console.Clear();
Console.Write("Введите количество элементов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Массив [{string.Join(" , ", array)}]");
double max = 0;
MaxArray(array, max);
Console.WriteLine($"Максимальный элемент массива: " + MaxArray(array, max));
double min = 0;
MinArray(array, min);
Console.WriteLine($"Минемальный элемент массива: " + MinArray(array, min));
double result = 0;
Console.WriteLine($"Разница между максимальным и минимальным: " + Result(result, MinArray(array, min), MaxArray(array, max)));
