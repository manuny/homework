Console.Write("Трехзначное число:");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 999)
{
	Console.Write("Вы ошиблись!\nТрехзначное число:");
	n = Convert.ToInt32(Console.ReadLine());
}
string n2 = Convert.ToString(n);
Console.WriteLine("вторая цифра этого числа " + n2[1]);