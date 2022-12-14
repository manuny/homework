Console.Clear();
Console.Write ("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int Conv = Convert.ToString(A).Length;
int b = 0;
int result = 0;
for (int i = 0; i < Conv; i++)
{
      b = A - A % 10;
      result = result + (A - b);
      A = A / 10;
}
Console.WriteLine("Ответ: " + result);
