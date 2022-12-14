Console.Write("пятизначное число:");
string? num = Console.ReadLine();
while (num!.Length != 5)
{
  Console.WriteLine($"Введи правильное число");
  num = Console.ReadLine();
}

  if (num[0]==num[4] && num[1]==num[3])
  {
    Console.WriteLine($"Ваше число: {num} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {num} - НЕ палиндром.");

