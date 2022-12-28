void InputMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = new Random().Next(-20, 21);
			Console.Write($"{matrix[i, j]} \t");
		}
		Console.WriteLine();
	}
}
int ReleaseMatrix(int[,] matrix, int a, int b, int k)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)

			if (i == a - 1 && j == b - 1)
				k = matrix[i, j];
	}
	return k;

}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);

Console.Write("Введите позицию элемента: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента: ");
int b = Convert.ToInt32(Console.ReadLine());
if (size[0] < a - 1 || size[1] < b - 1)
Console.WriteLine("такого элемента нет");
int k = 0;
ReleaseMatrix(matrix, a, b, k);
Console.WriteLine("значение этого элемента: " + ReleaseMatrix(matrix, a, b, k));
