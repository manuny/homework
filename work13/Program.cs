Console.Write("Число:");
int n = Convert.ToInt32(Console.ReadLine());
string t = Convert.ToString(n);
if (t.Length > 2)
{
	Console.Write(" третья цифра " + t [2]);
}
else
{
	Console.Write("третьей цифры нет");
}
