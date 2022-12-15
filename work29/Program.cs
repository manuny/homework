Console.Clear();
Console.Write ("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];

for (int i = 0; i < array.Length; i++)
{
Console.WriteLine ("Введите элементы массива: ");
array [i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"[{string.Join (", ", array)}]");