Console.Write("Трехзначное число:");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 999)
{
	Console.Write("Вы ошиблись!\nТрехзначное число:");
	n = Convert.ToInt32(Console.ReadLine());
} 
int n2 = n*10;
int n3 = n2/100;
int n4 = n3%10;
Console.WriteLine("вторая цифра этого числа " + n4);