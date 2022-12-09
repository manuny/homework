Console.Write("Число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 100)
{
	int t = n % 100;
	int a = t % 10;
	Console.Write(" третья цифра " + a);
}
else
{
	Console.Write("третьей цифры нет");
}