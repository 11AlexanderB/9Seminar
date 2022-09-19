try
{
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int Akkerman(int N, int M)
    {
        if (N == 0) return M + 1;
        else if (N > 0 && M == 0) return Akkerman(N - 1, 1);
        return Akkerman(N-1,Akkerman(N,M-1));
    }
    Console.WriteLine(Akkerman(n, m));
}
catch
{
    Console.WriteLine("Ошибка");
}