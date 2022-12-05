Console.Write("Введите день недели:");
int n=Convert.ToInt32(Console.ReadLine());
 while (n>8 || n<1)
 {
Console.Write("Вы ошиблись!\nВведите день недели:");
n=Convert.ToInt32(Console.ReadLine());
 }
 if (n==6 || n==7)
  Console.WriteLine("Да");
 else 
  Console.WriteLine("Нет");