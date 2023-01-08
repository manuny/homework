using System.Numerics;
void InputMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
			matrix[i, j] = new Random().Next(-10, 11);
	}
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
			Console.Write($"{matrix[i, j]}\t");
		Console.WriteLine();
	}
}


int ResultMatrix(int[,] matrix)
{
	int minR = 0;
	for (int i = 0; i < matrix.GetLength(1); i++)
		minR += matrix[0, i];

	for (int i = 1; i < matrix.GetLength(0); i++)
	{
		int sumR = 0;
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			sumR += matrix[i, j];
		}
		if (minR > sumR)
			minR = sumR;
	}
	return minR;
}


Console.Clear();
Console.Write("Введите размер прямоугольного массива ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//size[0] - row
//size[1] - column
while (size[0] == size[1])
{
	Console.Write("Вы ошиблись!\nВведите размер массива: ");
	size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine($"Результат: {ResultMatrix(matrix)}");
