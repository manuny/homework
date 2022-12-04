Console.Write("Введите число1:");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2:");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число3:");
int c=Convert.ToInt32(Console.ReadLine());
 if (a>b)
Console.WriteLine($"max:{a}");
 else if (b>c)
Console.WriteLine($"max:{b}");
 else if (c>a)
Console.WriteLine($"max:{c}");