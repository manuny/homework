int rec(int n, int m)
{
    if (n == m)
        return n;
    return rec(n, m - 1) + m;

}


Console.Clear();
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));