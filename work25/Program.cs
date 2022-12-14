Console.Clear();
Console.Write ("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine()), result = A;
for (int i = 2; i <= B; i++)
{
result = A * result;
}

Console.WriteLine("Ответ: " + result);